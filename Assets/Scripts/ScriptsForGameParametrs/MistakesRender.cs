using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MistakesRender :  GameParametrsInterface
{
    [SerializeField] private int _mistakes;
    [SerializeField] private string _section;
    [SerializeField] private int _lvlIndex;
    [SerializeField] private GameObject _text;

    private void Awake()
    {
        GetDifficultyParametr();
    }
    public override void GetDifficultyParametr()
    {
        _mistakes = StaticParametrHolder._mistakes;
        _text.GetComponent<Text>().text=(" " + _mistakes.ToString());
        _section = StaticParametrHolder._section;
        print("" + _section);
        _lvlIndex = StaticParametrHolder._lvlIndex;
        print(" "+ _lvlIndex);

    }
}
