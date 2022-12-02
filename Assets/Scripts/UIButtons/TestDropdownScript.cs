using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TestDropdownScript : MonoBehaviour//ТЕст, удалить перед сборкой
{
    public enum Section { Section1 = 1, Section2=2, Section3=3 };
    public void CheckDropdownValue( Dropdown dropdown)
    {
        if (dropdown.value+1 == ((int)Section.Section1))
        {
            print(dropdown.value+1);
        }
        else if (dropdown.value+1 == ((int)Section.Section2))
        {
            print(dropdown.value+1);
        }
        else if (dropdown.value+1 == ((int)Section.Section3))
        {
            print(dropdown.value+1);
        }
    }
}