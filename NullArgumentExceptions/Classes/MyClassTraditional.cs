using System;

namespace NullArgumentExceptions.Classes;

public class MyClassTraditional
{
    private readonly string paramName;

    public MyClassTraditional(string paramName)
    {
        if (paramName == null)
        {
            throw new ArgumentNullException(nameof(paramName));
        }

        this.paramName = paramName;
    }

    public static string MyMethod(string paramName)
    {
        if (paramName == null)
        {
            throw new ArgumentNullException(nameof(paramName));
        }

        return paramName;
    }
}
