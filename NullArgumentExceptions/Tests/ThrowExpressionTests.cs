using NullArgumentExceptions.Classes;
using System;

namespace NullArgumentExceptions.Tests;

public class ThrowExpressionTests : TestsBase
{
    protected override Action<string> ConstructorCall { get; } = param => new MyClassThrowExpression(param);

    protected override Func<string, string> MethodCall { get; } = param => MyClassThrowExpression.MyMethod(param);
}
