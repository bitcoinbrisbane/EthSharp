using System;

namespace ethsharp.solc.libsolidity.parsing
{
    public interface IParser
    {
        void parsePragmaVersion();

        void parseStructuredDocumentation();


        void parsePragmaDirective();

        void parseImportDirective();

        void parseContractKind();

        void parseContractDefinition();

        void parseInheritanceSpecifier();

        void parseVisibilitySpecifier();

        void parseOverrideSpecifier();

        void parseStateMutability();

        // from solc c++
        // void parsePragmaVersion(langutil::SourceLocation const& _location, std::vector<Token> const& _tokens, std::vector<std::string> const& _literals);
        // ASTPointer<StructuredDocumentation> parseStructuredDocumentation();
        // ASTPointer<PragmaDirective> parsePragmaDirective();
        // ASTPointer<ImportDirective> parseImportDirective();
        // /// @returns an std::pair<ContractKind, bool>, where
        // /// result.second is set to true, if an abstract contract was parsed, false otherwise.
        // std::pair<ContractKind, bool> parseContractKind();
        // ASTPointer<ContractDefinition> parseContractDefinition();
        // ASTPointer<InheritanceSpecifier> parseInheritanceSpecifier();
        // Visibility parseVisibilitySpecifier();
        // ASTPointer<OverrideSpecifier> parseOverrideSpecifier();
        // StateMutability parseStateMutability();
    }
}
