using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using QuickGraph;
using QuickGraph.Algorithms.TopologicalSort;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace D7.ModeledKnowledge.Infrastructure.Formula
{
    public interface Element
    {
        string Name { get; }

        string Formula { get; }

        object Value { get; set; }

        string Message { get; set; }
    }

    public class Tuple<E> where E : Element
    {
        public E Elem { get; set; }

        public IParseTree ParseTree { get; set; }
    }

    public class NamedElementCalculator<E> : ExpressionCalculator, IVariableProvider, IEnumerable<E> where E : Element
    {
        public event SyntaxError ErrorOutput;

        private AdjacencyGraph<E, Edge<E>> _Graph = new AdjacencyGraph<E, Edge<E>>();

        private Dictionary<string, Formula.Tuple<E>> _Elements = new Dictionary<string, Formula.Tuple<E>>();

        public virtual object this [string name]
        {
            get
            {
                if (!_Elements.ContainsKey(name))
                    return 0;

                return _Elements[name].Elem.Value;
            }

            set { _Elements[name].Elem.Value = value; }
        }

        private IList<E> _SortedCalculateList;

        public override void Initalize()
        {
            base.Initalize();

            VariableProvider = this;

            ErrorOutput += delegate (object owner, int line, int charPositionInLine, string msg)
            {
                  ((E)owner).Message = msg;
            };
        }

        public void Load(E[] list)
        {
            foreach (E elem in list)
            {
                _Graph.AddVertex(elem);
                _Elements[elem.Name] = new Formula.Tuple<E> { Elem = elem };
            }

            _SortedCalculateList = null;
        }

        public void Build()
        {
            Traveler<E> traveler = new Traveler<E>();

            if (ErrorOutput != null)
                traveler.ErrorOutput += ErrorOutput;

            traveler.OnVariable += delegate (string name)
            {
                _Graph.AddEdge(new Edge<E>(_Elements[name].Elem, traveler.Owner));
            };

            foreach (E elem in _Graph.Vertices)
            {
                IParseTree tree;

                traveler.Owner = elem;
                Result result = traveler.Execute(elem.Formula, out tree);
                _Elements[elem.Name].ParseTree = tree;
            }

            TopologicalSortAlgorithm<E, Edge<E>> t = new TopologicalSortAlgorithm<E, Edge<E>>(_Graph);

            t.Compute();

            _SortedCalculateList = t.SortedVertices;
        }
        
        public IList<E> Execute()
        {
            if (_SortedCalculateList == null)
                Build();

            foreach (E elem in _SortedCalculateList)
            {
                if (!string.IsNullOrEmpty(elem.Message))
                    continue;

                Result rlt = Visit(_Elements[elem.Name].ParseTree);
                elem.Value = rlt.Value;
            }

            return _SortedCalculateList;
        }

        public IEnumerator<E> GetEnumerator()
        {
            return _Graph.Vertices.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _Graph.Vertices.GetEnumerator();
        }
    }
}
