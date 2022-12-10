using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Text;


public class Word : MonoBehaviour
{
    private string word;
    private int length;
    private string section;
    


    public void createWord(int minRange, int maxRange)
    {
        section = "Животные";
        StreamReader dictionary;
        string lenghtRange = minRange.ToString() + '-' + maxRange.ToString();
        if (section == "Животные") dictionary = new StreamReader("Assets/Resources/Animals.txt", Encoding.GetEncoding(1251));
        else dictionary = new StreamReader("Assets/Resources/Plants.txt", Encoding.GetEncoding(1251));
        word = findWord(dictionary, lenghtRange);
        length = word.Length;
    }

    public string findWord(StreamReader dictionary, string lenghtRange)
    {
        int numberOfWord;
        int randomChoise;
        string buffer;
        buffer = dictionary.ReadLine();
        while (buffer != lenghtRange)
        {
            buffer = dictionary.ReadLine();
        }
        numberOfWord = int.Parse(dictionary.ReadLine());
        
        randomChoise = UnityEngine.Random.Range(1, numberOfWord);
        while (randomChoise != 0)
        {
            buffer = dictionary.ReadLine();
            randomChoise--;
        }
        
        return (buffer);
    }


    public void Print()
    {
        Debug.Log(word);
    }
    

}






