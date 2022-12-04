using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChooseSectionDropdown : MonoBehaviour
{
    [SerializeField] private Button _button;
    public enum Section { Section1 = 0, Section2 = 1, Section3 = 2 };
    public void CheckDropdownValue( Dropdown dropdown)
    {
        if (dropdown.value == ((int)Section.Section1))
        {
            _button.GetComponent<DifficultyParametrsSetters>().SetSection("Section1");
        }
        else if (dropdown.value == ((int)Section.Section2))
        {
            _button.GetComponent<DifficultyParametrsSetters>().SetSection("Section2");
        }
        else if (dropdown.value == ((int)Section.Section3))
        {
            _button.GetComponent<DifficultyParametrsSetters>().SetSection("Section3");
        }
    }
}