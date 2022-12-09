using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtounInteractable : MonoBehaviour
{
    [SerializeField] private Button _buttonMedium;
    [SerializeField] private Button _buttonHard;
    private int _levelComplete;

    private void Awake()
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
        PlayerPrefs.DeleteKey("GameWon");//переместить при неообходимости очистку списка выигранных игр
        PlayerPrefs.DeleteKey("GameLost");
    }
}
