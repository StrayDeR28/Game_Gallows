using UnityEngine;
using UnityEngine.UI;

public class DrawInputFields : MonoBehaviour
{
    [SerializeField] GameObject[] fields;
    [SerializeField] GameObject prefab;
    [SerializeField] string plainWord;

    void Start()
    {
        InputFieldsDrawing(plainWord, plainWord.Length);
    }

    public void InputFieldsDrawing(string word, int wordLength)
    {
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
        if (plainWord.Contains(character))
        {
            int index = plainWord.IndexOf(character);
            while (index != -1)
            {
                fields[index].GetComponent<Image>().sprite = GameObject.Find(character).GetComponent<Image>().sprite;
                fields[index].GetComponent<Image>().color = Color.yellow;
                GameObject.Find(character).GetComponent<Image>().color = Color.green;
                GameObject.Find(character).GetComponent<Button>().interactable = false;
                index = plainWord.IndexOf(character, index + 1);
            }
        }
        else
        {
            GameObject.Find(character).GetComponent<Image>().color = Color.red;
            GameObject.Find(character).GetComponent<Button>().interactable = false;
            // увеличиваем количество ошибок
        }
    }
}
