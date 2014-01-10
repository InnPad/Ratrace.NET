// Group.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Kinetic
{
    /// <summary>
    /// Group constructor. Groups are used to contain shapes or other groups.
    /// </summary>
    public class Group : Container
    {
        public Group(NodeConfig config)
            : base(config)
        {
        }
    }
}
