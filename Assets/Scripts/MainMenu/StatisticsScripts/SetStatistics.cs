using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetStatistics : MonoBehaviour
{
    private void Awake()
    {
        LastGameResult("Игра прервалась");
    }
   
    public void PassGameLevel()
    {
        LevelComplete();
        CountWins();
        LastGameResult("Победа");
    }
    public void LoseGameLevel()
    {
        CountDefeats();
        LastGameResult("Поражение");
    }

    public void CountDefeats()
    {
        int value = PlayerPrefs.GetInt("GameLost");
        value++;
        PlayerPrefs.SetInt("GameLost", value);
    }
    public void CountWins()
    {
        int value = PlayerPrefs.GetInt("GameWon");
        value++;
        PlayerPrefs.SetInt("GameWon", value);
    }
    public void LevelComplete()
    {
        if (StaticParametrHolder._lvlIndex == 1)
        {
            int value = StaticParametrHolder._lvlIndex;
            PlayerPrefs.SetInt("LevelComplete", value);
            StaticParametrHolder.SetLvlIndexStatic(0);
        }
        else if (StaticParametrHolder._lvlIndex == 2)
        {
            int value = StaticParametrHolder._lvlIndex;
            PlayerPrefs.SetInt("LevelComplete", value);
            StaticParametrHolder.SetLvlIndexStatic(0);
        }
    }
    public void LastGameResult(string value)
    {
        PlayerPrefs.SetString("LastGameResult", value);
    }
}
