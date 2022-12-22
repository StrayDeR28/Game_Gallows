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
       
        StreamReader dictionary;
        string lenghtRange = minRange.ToString() + '-' + maxRange.ToString();
        if (section == "Животные") dictionary = new StreamReader("Assets/Data/Animals.txt");
        else if (section == "Растения") dictionary = new StreamReader("Assets/Data/Plants.txt");
        else dictionary = new StreamReader("Assets/Data/Radiotechnic.txt");
        word = findWord(dictionary, lenghtRange);
        word=word.Replace("ё", "e");
        return (word);
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
        System.Random rnd = new System.Random();
        randomChoise = rnd.Next(1, numberOfWord+1);
        while (randomChoise != 0)
        {
            buffer = dictionary.ReadLine();
            randomChoise--;
        }
        
        return (buffer);
    }


  
    

}







