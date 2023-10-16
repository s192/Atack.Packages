using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atack.RollCaller.Model
{
    public class RollNode : TreeNode
    {
        public RollNode(string name) : base(name)
        {
        }

        public RollNode(string name, string tag) : base(name)
        {
            Tag = tag;
        }
    }
}
