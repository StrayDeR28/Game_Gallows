using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mistakes : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private List<GameObject> Part4;
    [SerializeField] private List<GameObject> Part8;
    [SerializeField] private List<GameObject> Part12;
    [SerializeField] private int mistakes;
    private List<GameObject> split;
    private int mistakesMade;

    public void start()
    {
        gallowSpliting(mistakes, Part4, Part8, Part12);
    }

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
    { if (mistakes == 8)
        {
            if (mistakesMade < Part8.Count)
            {
                Instantiate(Part8[mistakesMade], Part8[mistakesMade].transform.position, Part8[mistakesMade].transform.rotation);
                mistakesMade++;
            }
        }
    }
}