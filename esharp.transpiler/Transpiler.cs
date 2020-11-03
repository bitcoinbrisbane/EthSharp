using System;
using System.Collections.Generic;

namespace esharp.transpiler
{
    public class Transpiler
    {
        private readonly String _version;

        public Transpiler(String solcVersion)
        {
            _version = solcVersion;
        }

        public List<String> CastContract(String line)
        {
            throw new NotImplementedException();
        }
    }
}
