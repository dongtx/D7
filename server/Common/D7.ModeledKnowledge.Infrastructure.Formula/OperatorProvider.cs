using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace D7.ModeledKnowledge.Infrastructure.Formula
{
    public interface IOperatorProvider
    {
        object BinaryExecute(string opName, object a, object b);

        object UnaryExecute(string opName, object a);
    }

    public class OperatorProvider : IOperatorProvider
    {
        public object BinaryExecute(string opName, object a, object b)
        {
            MethodInfo method = a.GetType().GetMethod(opName, new Type[] { a.GetType(), b.GetType() } );
            return method.Invoke(null, new object[] { a, b });
        }

        public object UnaryExecute(string opName, object a)
        {
            MethodInfo method = a.GetType().GetMethod(opName, new Type[] { a.GetType() });
            return method.Invoke(null, new object[] { a });
        }
    }
}
