using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BreakInfinity;
using static BreakInfinity.BigDouble;

public class Methods : MonoBehaviour
{
    public static string NotationMethod(double x, string y)
    {
        /* if (x >= 1000)
        {
            var exponent = Math.Floor(Math.Log10(Math.Abs(x)));
            var mantissa = x / Math.Pow(10, exponent);
            return $"{mantissa:F2}e{exponent:F0}";
        }
        return x.ToString(y);*/
        if (x < 1000) return x.ToString(y);
        var exp = Math.Floor(Math.Log10(Math.Abs(x)));
        var mant = x / Math.Pow(10, exp);
        return $"{mant:F2}e{exp:F0}";
    }

    public static string NotationMethodBD(BigDouble x, string y)
    {
        /* if (x >= 1000)
        {
            var exponent = Floor(Log10(Abs(x)));
            var mantissa = x / Pow(10, exponent);
            return $"{mantissa:F2}e{exponent:F0}";
        }
        return x.ToString(y);*/
        if (x < 1000) return x.ToString(y);
        var exp = Floor(Log10(Abs(x)));
        var mant = x / Pow(10, exp);
        return $"{mant:F2}e{exp:F0}";
    }
}
