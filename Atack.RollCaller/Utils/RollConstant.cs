﻿using Atack.RollCaller.Model;

namespace Atack.RollCaller.Utils
{
    internal static class RollConstant
    {
        public static RollNode Root { get; set; } = new RollNode("Root");

        public static List<RollNode> CalledNodeList = new List<RollNode>();
    }
}
