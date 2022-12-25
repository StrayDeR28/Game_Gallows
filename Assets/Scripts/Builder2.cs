using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Text;
using UnityEngine.SceneManagement;

public class Builder2 : MonoBehaviour
{
 
    [SerializeField] private string section;
    [SerializeField] private int minLength;
    [SerializeField] private int maxLength;
    [SerializeField] private int mistakes;
    private string word;
    private int length;
    public GameObject start;
    public void Awake()
    {
        buildGameScene();
    }
    

    public void buildGameScene()
    {
        buildWord();
        buildGallow();
        DrawInputElements();
    }

    public void buildWord()
    {
        word = start.GetComponent<Word>().createWord(section, minLength, maxLength);
        PlayerPrefs.SetString("GameWord", word);
    }
    public void buildGallow()
    {
        start.GetComponent<Mistakes2>().gallowSpliting(mistakes);
    }

    public void DrawInputElements()
    {
        start.GetComponent<DrawInputFields2>().GameStart(word, section);
    }

    public void Update()
    {
        if (Input.GetKey("escape"))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}

