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

        public int Count => stack.Count;

        public IShape this[int index]
        {
            get
            {
                if (index < 0 || index >= stack.Count)
                {
                    throw new ArgumentOutOfRangeException("index", "Index is out of range.");
                }
                IShape[] array = stack.ToArray();
                return array[index];
            }
        }

        public void Push(IShape item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item", "Item cannot be null.");
            }
            stack.Push(item);
        }

        public IShape Pop()
        {
            if (stack.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            return stack.Pop();
        }

        public IShape Peek()
        {
            if (stack.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            return stack.Peek();
        }

        public void Clear()
        {
            stack.Clear();
        }

        public bool Contains(IShape item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item", "Item cannot be null.");
            }
            return stack.Contains(item);
        }

        public void CopyTo(IShape[] array, int arrayIndex)
        {
            if (array == null)
            {
                throw new ArgumentNullException("array", "Array cannot be null.");
            }
            if (arrayIndex < 0)
            {
                throw new ArgumentOutOfRangeException("arrayIndex", "Index is out of range.");
            }
            if (arrayIndex + stack.Count > array.Length)
            {
                throw new ArgumentException("The number of elements in the source collection is greater than the available space in the destination array.");
            }
            IShape[] tempArray = stack.ToArray();
            Array.Reverse(tempArray);
            Array.Copy(tempArray, 0, array, arrayIndex, tempArray.Length);
        }

        public IEnumerator<IShape> GetEnumerator()
        {
            return stack.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
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
            stack.Push(item);
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

    //public class QuadCollection : IEnumerable<IShape>, IEnumerable
    //{

    //    private Queue queue = new Queue();

    //    public IShape this[int index]
    //    {
    //        get
    //        {
    //            object toBeReturned = null;
    //            int queueSize = queue.Count;
    //            int counter = 0;
    //            while (queueSize > 0)
    //            {
    //                if (counter == index)
    //                {
    //                    toBeReturned = queue.Dequeue();
    //                    queue.Enqueue(toBeReturned);
    //                }
    //                else
    //                {
    //                    queue.Enqueue(queue.Dequeue());
    //                }
    //                counter++;
    //                queueSize--;
    //            }
    //            return (IShape)toBeReturned;
    //        }
    //    }

    //    public void Enqueue(object item)
    //    {
    //        if (!(item is IShape))
    //        {
    //            throw new ArgumentException("VehicleCollectionQueue can contain only elements that implement IShape");
    //        }
    //        queue.Enqueue(item);
    //    }

    //    public IEnumerator GetEnumerator()
    //    {
    //        return queue.GetEnumerator();
    //    }

    //    IEnumerator<IShape> IEnumerable<IShape>.GetEnumerator()
    //    {
    //        return queue.GetEnumerator() as IEnumerator<IShape>;
    //    }
    //}

    //public class QuadCollection<T> : IList<T> where T : IShape
    //{

    //    private Queue<T> queue = new Queue<T>();

    //    public T this[int index]
    //    {
    //        get
    //        {
    //            return queue.ElementAt(index);
    //        }
    //        set
    //        {
    //            Insert(index, value);
    //        }
    //    }

    //    public int Count
    //    {
    //        get { return queue.Count; }
    //    }

    //    public bool IsReadOnly
    //    {
    //        get { return false; }
    //    }

    //    public void Add(T item)
    //    {
    //        queue.Enqueue(item);
    //    }

    //    public void Clear()
    //    {
    //        queue.Clear();
    //    }

    //    public bool Contains(T item)
    //    {
    //        return queue.Contains(item);
    //    }

    //    public void CopyTo(T[] array, int arrayIndex)
    //    {
    //        queue.CopyTo(array, arrayIndex);
    //    }

    //    public IEnumerator<T> GetEnumerator()
    //    {
    //        return queue.GetEnumerator();
    //    }

    //    public int IndexOf(T item)
    //    {
    //        throw new InvalidOperationException();
    //    }

    //    public void Insert(int index, T item)
    //    {
    //        int queueSize = queue.Count;
    //        int counter = 0;
    //        while (queueSize >= 0)
    //        {
    //            if (counter == index)
    //            {
    //                queue.Enqueue(item);
    //            }
    //            else
    //            {
    //                queue.Enqueue(queue.Dequeue());
    //            }
    //            counter++;
    //            queueSize--;
    //        }
    //    }

    //    public bool Remove(T item)
    //    {
    //        throw new InvalidOperationException();
    //    }

    //    public void RemoveAt(int index)
    //    {
    //        throw new InvalidOperationException();
    //    }

    //    IEnumerator IEnumerable.GetEnumerator()
    //    {
    //        return queue.GetEnumerator();
    //    }

    //    public T First()
    //    {
    //        return queue.First();
    //    }
    //}
}
