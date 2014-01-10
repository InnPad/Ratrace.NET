// Container.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Kinetic
{
    public class Container : Node
    {
        /// <summary>
        /// Container constructor.
        /// </summary>
        public Container(NodeConfig config)
            : base(config)
        {
        }

        /// <summary>
        /// Add node to container
        /// </summary>
        /// <param name="child"></param>
        public void add(Node child)
        {
        }

        /// <summary>
        /// Clone node
        /// </summary>
        /// <param name="attrs"></param>
        public void clone(object attrs)
        {
        }

        /// <summary>
        /// Return an array of nodes that match the selector.
        /// </summary>
        /// <param name="selector"></param>
        public void get(string selector)
        {
        }

        /// <summary>
        /// Get children
        /// </summary>
        /// <returns></returns>
        public Node[] getChildren()
        {
            return null;
        }

        /// <summary>
        /// get shapes that intersect a point
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public Shape[] getIntersections(Point point)
        {
            return null;
        }

        /// <summary>
        /// Determine if node is an ancestorof descendant
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public bool isAncestorOf(Node node)
        {
            return false;
        }

        /// <summary>
        /// Remove all children
        /// </summary>
        public void removeChildren()
        {
        }
    }
}
