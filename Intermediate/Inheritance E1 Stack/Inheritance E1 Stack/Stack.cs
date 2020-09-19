using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Inheritance_E1_Stack
{
    public class Stack
    {
        private List<object> _stackList = new List<object>();

        public void Push(object obj)
        {
            if(obj == null)
            {
                throw new InvalidOperationException("Object can't be null");
            }
            _stackList.Insert(0, obj);
   
        }

        public object Pop()
        {
            if (_stackList.Count <= 0)
            {
                throw new InvalidOperationException("Stack is empty, cannot pop stack");

            }

            object obj = _stackList[0];
            _stackList.RemoveAt(0);
            return obj;

        }

        public void Clear()
        {
            _stackList.Clear();
        }
    }
}
