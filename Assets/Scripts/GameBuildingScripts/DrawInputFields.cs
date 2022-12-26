using UnityEngine;
using UnityEngine.UI;

public class DrawInputFields : MonoBehaviour
{
    [SerializeField] private GameObject gameWin;
    public GameObject forMistakes;
    private string pword;
    [SerializeField] private GameObject[] fields;
    [SerializeField] private GameObject prefab;
    [SerializeField] private GameObject text;

    private int rightCharacter;



    public void GameStart(string word, string section)
    {
        pword = word;
        Debug.Log(pword);
        InputFieldsDrawing(pword.Length, section);
    }

    public void InputFieldsDrawing(int wordLength, string section)
    {
        text.GetComponent<Text>().text = section;
        fields = new GameObject[wordLength];
        for (int i = 0; i < wordLength; i++)
        {
            fields[i] = Instantiate(prefab, transform.position, transform.rotation, transform.Find("InputField")) as GameObject;
            fields[i].name = i.ToString();
            fields[i].transform.localPosition = new Vector3(15 * (2 * i - wordLength + 1), 0, 0);
        }
    }

    public void GetAlphabet(string character)
    {   
   
        if (pword.Contains(character))
        {
            int index = pword.IndexOf(character);
            while (index != -1)
            {
                fields[index].GetComponent<Image>().sprite = GameObject.Find(character).GetComponent<Image>().sprite;
                fields[index].GetComponent<Image>().color = Color.yellow;
                rightCharacter++;
                GameObject.Find(character).GetComponent<Image>().color = Color.green;
                GameObject.Find(character).GetComponent<Button>().interactable = false;
                index = pword.IndexOf(character, index + 1);
            }
        }
        else
        {
            GameObject.Find(character).GetComponent<Image>().color = Color.red;
            GameObject.Find(character).GetComponent<Button>().interactable = false;
            forMistakes.GetComponent<Mistakes>().drawElements();
            forMistakes.GetComponent<AudioSource>().Play();
        }

        if (rightCharacter == pword.Length)
        {
            gameWin.GetComponent<ShowGameResult>().ShowResult();
            gameObject.GetComponent<SetStatistics>().PassGameLevel();
        }

    }
}
