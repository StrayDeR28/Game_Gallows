using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MistakesRender :  MonoBehaviour //Метод и поля будут в Builder-e, перенести туда
{
    [SerializeField] private int _mistakes;
    [SerializeField] private string _section;
    [SerializeField] private int _lvlIndex;//для дебага
    [SerializeField] private GameObject _text;//для дебага

    private void Awake()
    {
        GetDifficultyParametr();
    }
    public void GetDifficultyParametr()
    {
        _mistakes = StaticParametrHolder._mistakes;
        _text.GetComponent<Text>().text=(" " + _mistakes.ToString());//для дебага
        _section = StaticParametrHolder._section;
        print("section - " + _section);//для дебага
        _lvlIndex = StaticParametrHolder._lvlIndex;//для дебага
        print("lvl index = "+ _lvlIndex);//для дебага
    }
}
