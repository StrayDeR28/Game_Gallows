using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGameSceneButton : MonoBehaviour
{
    public void LoadGameScene()
    {
        SceneManager.LoadScene("MainGameScene");
    }
}
