using NullArgumentExceptions.Classes;
using System;

namespace NullArgumentExceptions.Tests;

public class TraditionalTests : TestsBase
{
    protected override Action<string> ConstructorCall { get; } = param => new MyClassTraditional(param);

    protected override Func<string, string> MethodCall { get; } = param => MyClassTraditional.MyMethod(param);
}
