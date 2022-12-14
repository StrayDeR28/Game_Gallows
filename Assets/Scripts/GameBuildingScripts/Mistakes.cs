using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mistakes : MonoBehaviour
{
    [SerializeField] private GameObject gameOver;
    private List<GameObject> split;
    private int mistakesMade;

    public int getMistakesMade()
    {
        return mistakesMade;
    }
    public void gallowSpliting(int numberOfMistakes, List<GameObject> fourParts, List<GameObject> eightParts,
        List<GameObject> twelveParts)
    {
        if (numberOfMistakes == 4)
        {
            split = fourParts;

        }
        else if (numberOfMistakes == 8)
        {
            split = eightParts;

        }
        else
        {
            split = twelveParts;

        }

    }

    public void drawElements()
    {
        
        if (mistakesMade < split.Count)
        {
            Instantiate(split[mistakesMade], split[mistakesMade].transform.position, split[mistakesMade].transform.rotation);
            mistakesMade++;
            PlayerPrefs.SetInt("GameMistakes", mistakesMade);
            if (mistakesMade == split.Count)
            {
                gameOver.SetActive(true);
                gameObject.GetComponent<SetStatistics>().LoseGameLevel();
            }
        }
        

    }
}