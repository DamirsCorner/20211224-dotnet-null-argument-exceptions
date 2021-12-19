using NullArgumentExceptions.Classes;
using System;

namespace NullArgumentExceptions.Tests;

public class DotNet6Tests : TestsBase
{
    protected override Action<string> ConstructorCall { get; } = param => new MyClassDotNet6(param);

    protected override Func<string, string> MethodCall { get; } = param => MyClassDotNet6.MyMethod(param);
}
