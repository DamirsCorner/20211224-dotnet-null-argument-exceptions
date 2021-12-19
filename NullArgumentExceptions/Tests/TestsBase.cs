using FluentAssertions;
using NUnit.Framework;
using System;

namespace NullArgumentExceptions.Tests;

public abstract class TestsBase
{
    protected abstract Action<string> ConstructorCall { get; }
    protected abstract Func<string, string> MethodCall { get; }

    [Test]
    public void ConstructorShouldThrowWhenParamIsNull()
    {
        var action = () => ConstructorCall(null!);

        action.Should().Throw<ArgumentNullException>()
            .WithParameterName("paramName");
    }

    [Test]
    public void ConstructorShouldNotThrowWhenParamIsNotNull()
    {
        var action = () => ConstructorCall("not null");

        action.Should().NotThrow();
    }

    [Test]
    public void MethodShouldThrowWhenParamIsNull()
    {
        var action = () => MethodCall(null!);

        action.Should().Throw<ArgumentNullException>()
            .WithParameterName("paramName");
    }

    [Test]
    public void MethodShouldNotThrowWhenParamIsNotNull()
    {
        var action = () => MethodCall("not null");

        action.Should().NotThrow();
    }
}
