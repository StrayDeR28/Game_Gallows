using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Statistics : MonoBehaviour
{
    [SerializeField] private GameObject _wins;
    [SerializeField] private GameObject _defeats;
    public void ShowStatisc()
    {
        _wins.GetComponent<Text>().text = (" " + PlayerPrefs.GetInt("GameWon").ToString());//обращаемся к хранящимся в PlayerPrefs данным и выводим их
        _defeats.GetComponent<Text>().text = (" " + PlayerPrefs.GetInt("GameLost").ToString());
    }
    public void ResetStatistic()
    {
        PlayerPrefs.DeleteKey("GameWon");//переместить в статистику
        PlayerPrefs.DeleteKey("GameLost");
    }
}
