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
            T tmp = default(T);
            if (IsEmpty())
            {
                throw new Exception("List is empty");
            }
            if (index < 0 || index > _last)
            {
                throw new Exception("Delete index is error");
            }

            if (index == _last)
            {
                tmp = _data[index];
            }
            else
            {
                tmp = _data[index];
                for (int i = index; i < _last; i++)
                {
                    _data[index] = _data[index + 1];//左移 时间复杂度为O(n)。
                }
            }
            _last--;
            return tmp;
        }

        public T GetElem(int index)
        {
            if (IsEmpty() || (index < 0) || (index > _last))
            {
                throw new Exception("List is empty or index is error");
            }
            return _data[index];
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
            if (index < 0 || index > _last + 1)
            {
                throw new Exception("Insert index is error");
            }

            if (index == _last + 1)
            {
                _data[index] = item;
            }
            else
            {
                for (int i = _last; i > index - 1; i--)
                {
                    _data[i + 1] = _data[i];//后移 时间复杂度为O(n)。
                }
                _data[index] = item;
            }
            _last ++;
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
            if (IsEmpty())
            {
                throw new Exception("List is empty");
            }
            for (int i = 0; i <= _last; i++)//时间复杂度为O(n)。
            {
                if (value.Equals(_data[i]))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
