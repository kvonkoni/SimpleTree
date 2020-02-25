﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace EasyTree.Iterators
{
    public abstract class IteratorBase : IEnumerable
    {
        protected Node _node;

        protected List<Node> _nodelist;

        public delegate void PerformFunction(Node node);

        public IteratorBase(Node node)
        {
            _node = node;
            _nodelist = new List<Node>();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public NodeEnum GetEnumerator()
        {
            return new NodeEnum(_nodelist);
        }
    }
}