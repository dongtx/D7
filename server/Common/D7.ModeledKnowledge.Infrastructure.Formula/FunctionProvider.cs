using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using static D7.ModeledKnowledge.Infrastructure.Formula.ExpressionCalculator;

namespace D7.ModeledKnowledge.Infrastructure.Formula
{
    public interface IFunctionProvider
    {
        Result Invoke(string id, object[] arguments);
    }

    public class FunctionProvider : IFunctionProvider
    {
        private bool _CaseSensitive;
        private object _Object;

        public FunctionProvider(object obj)
        {
            _Object = obj;
        }

        public FunctionProvider(bool caseSensitive = false)
        {
            _CaseSensitive = caseSensitive;
        }

        public Result Invoke(string id, object[] arguments)
        {
            Type type = _Object.GetType();
            MethodInfo method = type.GetMethod(id);

            if (method == null)
                throw new MissingMethodException(id);

            object obj = method.Invoke(_Object, arguments);

            return new Result { Value = obj };
        }
    }
}
