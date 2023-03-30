 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonScript : MonoBehaviour
{
    Text textField;

    int number = 1;

    void Start()
    {
        textField = GameObject.Find("Day").GetComponent<Text>();
       

    }

    public void changeText()
    {
     
        

        number += 1;
        textField.text = "" + number;

        if (number == 30)
        {
            number = 0;
        }
    }
}
