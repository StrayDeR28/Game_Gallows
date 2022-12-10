using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetStatistics : MonoBehaviour
{
    public void PassGameLevel()
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
        int value2 = PlayerPrefs.GetInt("GameWon");
        value2++;
        PlayerPrefs.SetInt("GameWon",value2);
    }
    public void LoseGameLevel()
    {
        int value2 = PlayerPrefs.GetInt("GameLost");
        value2++;
        PlayerPrefs.SetInt("GameLost", value2);
    }
}
