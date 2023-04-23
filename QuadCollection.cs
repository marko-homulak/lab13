using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    public class QuadCollection : IEnumerable<IShape>, IEnumerable
    {

        private Stack<IShape> stack = new Stack<IShape>();

        public IShape this[int index]
        {
            get
            {
                if (index < 0 || index >= stack.Count)
                {
                    throw new IndexOutOfRangeException();
                }
                return stack.ElementAt(stack.Count - index - 1);
            }
        }

        public void Push(IShape item)
        {
            stack.Push(item);
        }

        public IShape Pop()
        {
            return stack.Pop();
        }

        public IEnumerator GetEnumerator()
        {
            return stack.GetEnumerator();
        }

        IEnumerator<IShape> IEnumerable<IShape>.GetEnumerator()
        {
            return stack.GetEnumerator();
        }
    }


    public class QuadCollection<T> : IList<T> where T : IShape
    {
        private Stack<T> stack = new Stack<T>();

        public T this[int index]
        {
            get { return stack.ElementAt(index); }
            set { throw new InvalidOperationException(); }
        }

        public int Count
        {
            get { return stack.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public void Add(T item)
        {
            stack.Push(item);
        }

        public void Clear()
        {
            stack.Clear();
        }

        public bool Contains(T item)
        {
            return stack.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            stack.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return stack.GetEnumerator();
        }

        public int IndexOf(T item)
        {
            throw new InvalidOperationException();
        }

        public void Insert(int index, T item)
        {
            throw new InvalidOperationException();
        }

        public bool Remove(T item)
        {
            if (!stack.Contains(item))
            {
                return false;
            }
            Stack<T> tempStack = new Stack<T>();
            while (stack.Count > 0)
            {
                T current = stack.Pop();
                if (!current.Equals(item))
                {
                    tempStack.Push(current);
                }
            }
            while (tempStack.Count > 0)
            {
                stack.Push(tempStack.Pop());
            }
            return true;
        }

        public void RemoveAt(int index)
        {
            throw new InvalidOperationException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return stack.GetEnumerator();
        }
    }

}
