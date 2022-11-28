using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("MainMenuFedScene");//Измени имя сцены на необходимое
    }
}
