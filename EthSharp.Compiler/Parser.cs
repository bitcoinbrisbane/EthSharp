using System;

namespace EthSharp.Compiler
{
    public class Parser
    {
        public void ParseContractDefinition()
        {

        }


        // Visibility Parser::parseVisibilitySpecifier()
        // {
        //     Visibility visibility(Visibility::Default);
        //     Token token = m_scanner->currentToken();
        //     switch (token)
        //     {
        //         case Token::Public:
        //             visibility = Visibility::Public;
        //             break;
        //         case Token::Internal:
        //             visibility = Visibility::Internal;
        //             break;
        //         case Token::Private:
        //             visibility = Visibility::Private;
        //             break;
        //         case Token::External:
        //             visibility = Visibility::External;
        //             break;
        //         default:
        //             solAssert(false, "Invalid visibility specifier.");
        //     }
        //     m_scanner->next();
        //     return visibility;
        // }

        public void ParseVisibilitySpecifier()
        {

        }

        public void ParseFunctionDefinition()
        {

        }
    }
}