using System;

namespace NullArgumentExceptions.Classes;

public class MyClassDotNet6
{
    private readonly string paramName;

    public MyClassDotNet6(string paramName)
    {
        ArgumentNullException.ThrowIfNull(paramName);
        this.paramName = paramName;
    }

    public static string MyMethod(string paramName)
    {
        ArgumentNullException.ThrowIfNull(paramName);
        return paramName;
    }
}
