using System;
using System.Linq.Expressions;
using System.Linq.Expressions.CompilerServices;
using Xunit;

namespace Microsoft.Reactive.Bcl.Linq.Expressions.CompilerServices.Tests
{
    public class FreeVariableScannerTests
    {
        [Fact]
        public void Placeholder()
        {
            Assert.Throws<NotImplementedException>(() => FreeVariableScanner.HasFreeVariables(Expression.Default(typeof(int))));
        }
    }
}
