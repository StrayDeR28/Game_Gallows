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
        ChangeAlpha(_buttonMedium);
        ChangeAlpha(_buttonHard);
    }
    public void ResetButton()
    {
        _buttonMedium.interactable = false;
        _buttonHard.interactable = false;
        ChangeAlpha(_buttonMedium);
        ChangeAlpha(_buttonHard);
        PlayerPrefs.DeleteKey("LevelComplete");
    }
    private void ChangeAlpha(Button button)//Изменение цвета неактивных кнопок
    {
        if(button.interactable == false)
        {
            Color tempColor = button.GetComponentInChildren<Text>().color;
            tempColor.a = 0.65f;
            button.GetComponentInChildren<Text>().color = tempColor;
        }
        else if(button.interactable == true)
        {
            Color tempColor = button.GetComponentInChildren<Text>().color;
            tempColor.a = 1f;
            button.GetComponentInChildren<Text>().color = tempColor;
        }
    }
}
