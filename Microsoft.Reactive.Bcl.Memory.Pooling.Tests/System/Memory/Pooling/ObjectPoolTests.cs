using System;
using System.Memory.Pooling;
using Xunit;

namespace Microsoft.Reactive.Bcl.Memory.Pooling.Tests
{
    public class ObjectPoolTests
    {
        [Fact]
        public void Placeholder()
        {
            Assert.Throws<NotImplementedException>(() => new ObjectPool<object>().Allocate());
        }
    }
}
