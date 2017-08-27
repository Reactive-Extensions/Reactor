using System;

namespace System.Memory.Pooling
{
    public class ObjectPool<T>
    {
        public T Allocate() => throw new NotImplementedException();
        public void Free(T obj) => throw new NotImplementedException();
    }
}
