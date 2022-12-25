using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mistakes2 : MonoBehaviour
{

    [SerializeField] private GameObject gameOver;
    [SerializeField] private List<GameObject> split;
    private int mistakesMade;
    private int mistakes;
    public int getMistakesMade()
    {
        return mistakesMade;
    }
    public void gallowSpliting(int numberOfMistakes)
    {
        mistakes = numberOfMistakes;
    }
    public void drawElements()
    {
        if (mistakesMade < split.Count)
        {
            if (mistakes == 4) drawElements4();
            if (mistakes == 8) drawElements8();
            if (mistakes == 12) drawElements12();
            PlayerPrefs.SetInt("GameMistakes", mistakesMade);
            if (mistakesMade == split.Count)
            {
                gameOver.GetComponent<ShowGameResult>().ShowResult();
                gameObject.GetComponent<SetStatistics>().LoseGameLevel();
            }
        }
    }

    public void drawElements4()
    {   int i = 0;
        while (i < 3)
        {
            Instantiate(split[mistakesMade], split[mistakesMade].transform.position, split[mistakesMade].transform.rotation);
            mistakesMade++;
            i++;

        }
    }

    public void drawElements8()
    {   if (mistakesMade < 4)
        {
            Instantiate(split[mistakesMade], split[mistakesMade].transform.position, split[mistakesMade].transform.rotation);
            mistakesMade++;
        }
        else
        {
            int i = 0;
            while (i < 2)
            {
                Instantiate(split[mistakesMade], split[mistakesMade].transform.position, split[mistakesMade].transform.rotation);
                mistakesMade++;
                i++;
            }

        }
    }

    public void drawElements12()
    {   
        Instantiate(split[mistakesMade], split[mistakesMade].transform.position, split[mistakesMade].transform.rotation);
        mistakesMade++;
    }
}
