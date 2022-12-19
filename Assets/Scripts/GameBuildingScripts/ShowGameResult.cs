using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ShowGameResult : MonoBehaviour
{
    [SerializeField] private GameObject showBackground;
    public void ShowResult()
    {
        gameObject.SetActive(true);
        showBackground.SetActive(true);
    }
}
