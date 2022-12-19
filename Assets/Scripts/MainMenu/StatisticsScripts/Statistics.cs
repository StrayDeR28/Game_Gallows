using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//PlayerPrefs хранят в себе:
// "GameWon"; "GameLost"; "LevelComplete"; "GameWord"; "LastGameResult"; GameSection; "GameMistakes"
public class Statistics : MonoBehaviour
{
    private void Awake()
    {
        ShowStatistic();
    }
    [SerializeField] private GameObject _wins;
    [SerializeField] private GameObject _defeats;
    [SerializeField] private GameObject _wdCompare;
    [SerializeField] private GameObject _gameWord;
    [SerializeField] private GameObject _lastGameResult;
    [SerializeField] private GameObject _gameSection;
    [SerializeField] private GameObject _gameMistakes;
    public void ShowStatistic()
    {
        int wins = PlayerPrefs.GetInt("GameWon");
        int defeats = PlayerPrefs.GetInt("GameLost");
        _wins.GetComponent<Text>().text = ("Победы: " + PlayerPrefs.GetInt("GameWon").ToString());//обращаемся к хранящимся в PlayerPrefs данным и выводим их
        _defeats.GetComponent<Text>().text = ("Поражения: " + PlayerPrefs.GetInt("GameLost").ToString());
        if (defeats != 0) { _wdCompare.GetComponent<Text>().text = ("Соотношение Побед/поражений: " + Mathf.Round(wins * 100 / defeats) * 0.01); }
        else { _wdCompare.GetComponent<Text>().text = "Соотношение Побед/поражений: " + PlayerPrefs.GetInt("GameWon").ToString(); }
        _gameWord.GetComponent<Text>().text = ("Слово: " + PlayerPrefs.GetString("GameWord"));
        _gameSection.GetComponent<Text>().text = ("Раздел: " + PlayerPrefs.GetString("GameSection"));
        _lastGameResult.GetComponent<Text>().text = ("Итог: ") + PlayerPrefs.GetString("LastGameResult");
        _gameMistakes.GetComponent<Text>().text = ("Ошибок допущено: " + PlayerPrefs.GetInt("GameMistakes").ToString());
    }
    public void ResetStatistic()//Сделать кнопкой в статистике
    {
        PlayerPrefs.DeleteAll();
        ShowStatistic();
    }
}
