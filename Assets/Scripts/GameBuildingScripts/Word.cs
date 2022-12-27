using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Text;


public class Word : MonoBehaviour
{
    private string word;

   
    public string createWord(string section, int minRange, int maxRange)
    {   
       
        TextAsset dictionary;
        string lenghtRange = minRange.ToString() + '-' + maxRange.ToString();
        if (section == "Животные") dictionary = Resources.Load<TextAsset>("Animals");
        else if (section == "Растения") dictionary = Resources.Load<TextAsset>("Plants");
        else dictionary = Resources.Load<TextAsset> ("Radiotechnic");
        word = findWord(dictionary, lenghtRange);
        return (word);
    }

    public string findWord(TextAsset dictionary, string lenghtRange)
    {
        List<string> lines = new List<string>(dictionary.text.Split("\n"));
        for (int j = 0; j < lines.Count; j++) lines[j] = lines[j].Substring(0, lines[j].Length - 1);
        int numberOfWord;
        int randomChoise;
        int i = 0;  
        
        while (lines[i] != lenghtRange)
        { 
            i++;
        }
        i++;
        numberOfWord = int.Parse(lines[i]);
        
        System.Random rnd = new System.Random();
        randomChoise = rnd.Next(1, numberOfWord+1);
        while (randomChoise != 0)
        {
            i++;
            randomChoise--;
        }

        return (lines[i]);
    }


  
    

}







