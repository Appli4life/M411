namespace My.Collections
{
    using System;

    public interface ICollection
    {
        int Count { get; }
        void Clear();
   }
}