using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyParametrsSetters : MonoBehaviour
{
    public void SetMistakes(int value)//Не статитики т.к. к ним обращаються кнопки -> методы должны лежать на объекте. (static не может лежать на объекте)
    {
        StaticParametrHolder._mistakes = value;
    }
    public void SetMinLength(int value)
    {
        StaticParametrHolder._minlength = value;
    }
    public void SetMaxLength(int value)
    {
        StaticParametrHolder._maxlength = value;
    }
    public void SetSection(string value)
    {
        StaticParametrHolder._section = value;
    }
    public void SetLvlIndex(int value)
    {
        StaticParametrHolder._lvlIndex = value;
    }
    void Awake()
    {
        SetMinLength(3);
        SetMaxLength(5);
        SetMistakes(12);
        SetSection("Животные");
    }
}
