﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace EthSharp.Compiler
{
    public class Compiler
    {
        public IList<Line> Lines { get; set; }

        private Stack _lines;

        public Contract Contract
        {
            get; private set;
        }
        public IList<Function> GetFunctions()
        {
            List<Function> functions = new List<Function>();
            Function functionToAdd = new Function();

            Int32 LBraceCount = 0;
            Int32 RBraceCount = 0;

            Boolean inFunctionBlock = false;
            
            foreach(Line line in this.Lines)
            {
                if (line.Data.Trim().StartsWith("function"))
                {
                    inFunctionBlock = true;
                    functionToAdd = new Function();
                    functionToAdd.Name = GetFunctionNameFromLine(line.Data);
                }

                if (inFunctionBlock)
                {
                    Regex leftBraceRegex = new Regex("{");
                    MatchCollection leftBrachMatches = leftBraceRegex.Matches(line.Data);

                    LBraceCount += leftBrachMatches.Count;

                    Regex rightBraceRegex = new Regex("}");
                    MatchCollection rightBrachMatches = leftBraceRegex.Matches(line.Data);

                    RBraceCount += rightBrachMatches.Count;

                    if (RBraceCount == LBraceCount)
                    {
                        functions.Add(functionToAdd);
                        inFunctionBlock = false;

                        functionToAdd = null;
                    }
                }
            }

            return functions;
        }

        public String GetFunctionNameFromLine(String line)
        {
            String[] words = line.Trim().Split(' ');
            if (words[0] == "function")
            {
                return words[1].Trim();
            }

            return "";
        }

        public IList<Function> GetFunctions(Contract contract)
        {
            var functionLine = contract.Lines.First(x => x.Data.Trim().StartsWith("function"));

            Int32 leftBraceCount = 0;
            Int32 rightBraceCount = 0;
            
            foreach(Line line in contract.Lines)
            {
                Regex leftBraceRegex = new Regex("{");
                MatchCollection leftBrachMatches = leftBraceRegex.Matches(line.Data);

                leftBraceCount += leftBrachMatches.Count;

                Regex rightBraceRegex = new Regex("}");
                MatchCollection rightBrachMatches = leftBraceRegex.Matches(line.Data);

                rightBraceCount += rightBrachMatches.Count;

                if (rightBraceCount == leftBraceCount)
                {
                    Function function = new Function();
                    function.Name = GetFunctionNameFromLine(line.Data);
                }   
            }

            return new List<Function>();
        }

        //Make this private
        public Contract GetContract()
        {
            Line contractLine = Lines.OrderBy(x => x.Number).First(x => x.Data.Trim().StartsWith("contract"));
            this.Contract = new Contract() { StartLineNumber = contractLine.Number };

            String[] contractLineWords = contractLine.Data.Trim().Split(' ');
            if (contractLineWords[0] == "contract")
            {
                contractLine.LineType = LineType.BEGIN_CONTRACT;
                
                //TODO: DO REGEX TO VALIDATE ALPHABET
                this.Contract.Name = contractLineWords[1].Trim();
            }

            if (contractLineWords.Length > 2)
            {
                //TODO check for "{"
            }

            Line contractEndBrace = Lines.OrderBy(x => x.Number).Last(x => x.Data.Trim().StartsWith("}"));
            return this.Contract;
        }

        public Boolean Compile(String file)
        {
            Parse(file);

            GetContract();

            return true;
        }

        public void Parse(String file)
        {
            this.Lines = new List<Line>();
            //this.Contracts = new List<Contract>();

            Int32 i = 0;
            foreach (string line in File.ReadLines(file))
            {
                Lines.Add(new Line(line) { Number = i + 1 });

                i++;
            }
        }
    }
}
