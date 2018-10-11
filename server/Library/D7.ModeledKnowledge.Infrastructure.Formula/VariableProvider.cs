using System;
using System.Collections.Generic;
using System.Text;

namespace D7.ModeledKnowledge.Infrastructure.Formula
{
    public interface IVariableProvider
    {
        object this[string index]{get;set;}
    }

    public class VariableProvider : IVariableProvider
    {
        private Dictionary<string, object> _Cache = new Dictionary<string, object>();
        private bool _CaseSensitive;

        public VariableProvider(bool caseSensitive = false)
        {
            _CaseSensitive = caseSensitive;
        }

        public object this[string index]
        {
            get
            {
                string idx = _CaseSensitive ? index : index.ToUpper();

                if (_Cache.ContainsKey(idx))
                    return _Cache[idx];
                else
                    return 0;
            }
            set
            {
                string idx = _CaseSensitive ? index : index.ToUpper();

                _Cache[idx] = value;
            }
        }
    }
}