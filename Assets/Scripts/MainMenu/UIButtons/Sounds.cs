using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    [SerializeField] private AudioSource audioButton;
    [SerializeField] private AudioClip click;

   public void playOnClick () 
    {
        audioButton.PlayOneShot(click);
    }



}
