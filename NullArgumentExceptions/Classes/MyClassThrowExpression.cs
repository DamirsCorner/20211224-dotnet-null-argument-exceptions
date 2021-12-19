using System;

namespace NullArgumentExceptions.Classes;

public class MyClassThrowExpression
{
    private readonly string paramName;

    public MyClassThrowExpression(string paramName)
    {
        this.paramName = paramName ?? throw new ArgumentNullException(nameof(paramName));
    }

    public static string MyMethod(string paramName)
    {
        return paramName ?? throw new ArgumentNullException(nameof(paramName));
    }
}
