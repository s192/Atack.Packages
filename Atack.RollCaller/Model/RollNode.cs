using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atack.RollCaller.Model
{
    public class RollNode
    {
        public RollNode(string name)
        {
            Name = name;
            Children = new RollNodeCollection();
        }

        public string Name { get; set; }

        public RollNodeCollection Children { get; set; }

        public string? Content { get; set; }
    }

    public class RollNodeCollection : IEnumerable<RollNode>, IEnumerable
    {
        private List<RollNode> _cache = new List<RollNode>();

        public RollNodeCollection()
        {

        }

        public RollNode this[int index]
        {
            get { return _cache[index]; }
            set { _cache[index] = value; }
        }

        public void Add(RollNode rollNode)
        {
            _cache.Add(rollNode);
        }

        public int Count => _cache.Count;

        public IEnumerator<RollNode> GetEnumerator()
        {
            foreach (var item in _cache)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var item in _cache)
            {
                yield return item;
            }
        }
    }
}
