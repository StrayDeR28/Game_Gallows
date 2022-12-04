using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MistakesRender :  GameParametrsInterface
{
    [SerializeField] private int _mistakes;
    [SerializeField] private string _section;
    [SerializeField] private GameObject _text;
    public override void GetDifficultyParametr()
    {
        _mistakes = StaticParametrHolder._mistakes;
        _text.GetComponent<Text>().text=(" " + _mistakes.ToString());
        _section = StaticParametrHolder._section;
        print("" + _section);
    }
}
