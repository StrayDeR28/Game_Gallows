using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StaticParametrHolder
{
    public static int _mistakes = 12;//По-хорошему бы они должны быть private
    public static int _minlength = 3;
    public static int _maxlength = 5;
    public static string _section = "Животные";
    public static int _lvlIndex;

    public static void SetLvlIndexStatic(int value)
    {
        _lvlIndex = value;
    }
}
