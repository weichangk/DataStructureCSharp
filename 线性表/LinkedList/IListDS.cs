namespace LinkedList
{
    /// <summary>
    /// 线性表接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IListDS<T>
    {
        /// <summary>
        /// 求长度
        /// </summary>
        /// <returns></returns>
        int GetLenght();

        /// <summary>
        /// 清空
        /// </summary>
        void Clear();

        /// <summary>
        /// 是否为空
        /// </summary>
        /// <returns></returns>
        bool IsEmpty();

        /// <summary>
        /// 是否满
        /// </summary>
        /// <returns></returns>
        public bool IsFull();

        /// <summary>
        /// 追加
        /// </summary>
        /// <param name="item"></param>
        void Append(T item);

        /// <summary>
        /// 插入
        /// </summary>
        /// <param name="item"></param>
        /// <param name="index"></param>
        void Insert(T item, int index);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        T Delete(int index);

        /// <summary>
        /// 取表元
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        T GetElem(int index);

        /// <summary>
        /// 按值查找
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        int Locate(T value);
    }
}
