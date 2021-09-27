using System;

namespace LinkedList
{
    /// <summary>
    /// 顺序表
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SeqList<T> : IListDS<T>
    {
        /// <summary>
        /// 顺序表的容量
        /// </summary>
        int _maxsize;

        /// <summary>
        /// 数组，用于存储顺序表中的数据元素
        /// </summary>
        T[] _data;

        /// <summary>
        /// 指示顺序表最后一个元素的位置
        /// </summary>
        int _last;

        /// <summary>
        /// 顺序表的容量
        /// </summary>
        public int Maxsize
        {
            get => _maxsize;
            set => _maxsize = value;
        }

        /// <summary>
        /// 指示顺序表最后一个元素的位置
        /// </summary>
        public int Last
        {
           get => _last;
        }
        /// <summary>
        /// 索引器
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T this[int index]
        {
            get => _data[index];
            set => _data[index] = value;
        }

        
        public void Append(T item)
        {
            if (IsFull())
            {
                throw new Exception("List is full");
            }
            _data[++_last] = item;
        }

        public void Clear()
        {
            _last = -1;
        }

        public T Delete(int index)
        {
            throw new NotImplementedException();
        }

        public T GetElem(int index)
        {
            throw new NotImplementedException();
        }

        public int GetLenght()
        {
            return _last + 1;
        }

        public void Insert(T item, int index)
        {
            if (IsFull())
            {
                throw new Exception("List is full");
            }
        }

        public bool IsEmpty()
        {
            return _last == -1;
        }

        public bool IsFull()
        {
            return _last == _maxsize - 1;
        }
        public int Locate(T value)
        {
            throw new NotImplementedException();
        }
    }
}
