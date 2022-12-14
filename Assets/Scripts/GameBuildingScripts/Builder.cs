using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Text;


public class Builder : MonoBehaviour
{
    [SerializeField] private string section;
    [SerializeField] private int minLength;
    [SerializeField] private int maxLength;
    [SerializeField] private int mistakes;
    [SerializeField] private List<GameObject> gallowPart4Mistake;
    [SerializeField] private List<GameObject> gallowPart8Mistake;
    [SerializeField] private List<GameObject> gallowPart12Mistake;
    private string word;
    private int length;
    public GameObject start;

    private void Awake()
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
        Debug.Log(word);
        
    }

    public void buildGallow()
    {
        start.GetComponent<Mistakes>().gallowSpliting(mistakes, gallowPart4Mistake, gallowPart8Mistake, gallowPart12Mistake);


    }

    public void DrawInputElements()
    {
        start.GetComponent<DrawInputFields>().GameStart(word, section);
    }

    

 
}
    
   
