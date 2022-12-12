using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInteractable : MonoBehaviour
{
    [SerializeField] private Button _buttonMedium;
    [SerializeField] private Button _buttonHard;
    private int _levelComplete;

    private void Awake()//при переходе на сцену MainMenu значения сразу обновляются
    {
        SetInteractable();
    }
    public void SetInteractable()
    {
        _levelComplete = PlayerPrefs.GetInt("LevelComplete");
        switch (_levelComplete)
        {
            case 1:
                _buttonMedium.interactable = true;
                break;
            case 2:
                _buttonMedium.interactable = true;
                _buttonHard.interactable = true;
                break ;
        }
    }
    public void ResetButton()
    {
        _buttonMedium.interactable = false;
        _buttonHard.interactable = false;
        PlayerPrefs.DeleteKey("LevelComplete");
    }
}
