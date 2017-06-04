﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class ArrayTypedStack : IStack   
    {
        private object[] items;
        private int top = -1;

        public ArrayTypedStack(int itemCount)
        {
            this.items = new object[itemCount];
        }
        public int Top
        {
            get
            {
                return top;
            }

            set
            {
                top = value;
            }
        }

        public bool IsEmpty()
        {
            return Top == -1 ? true : false; 
        }

        public object Peek()
        {
            return items[Top];
        }

        public object Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("Hata! Stack Boş! [Downflow]");
            }

            object temp = items[--Top];
            return temp;
        }

        public void Push(object item)
        {
            if (items.Length == Top + 1)
            {
                throw new Exception("Hata! Stack Dolu [Owerflow]");
            }
            items[++Top] = item;
        }
    }
}
