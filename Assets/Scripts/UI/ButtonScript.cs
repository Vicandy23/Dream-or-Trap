using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public Text textDisplay;

    void Start()
    {
        textDisplay.gameObject.SetActive(false);
    }

   
    public void DisplayText()
    {
        
        textDisplay.gameObject.SetActive(!textDisplay.gameObject.activeSelf);

        
        if (textDisplay.gameObject.activeSelf)
        {
            string message = textDisplay.text;
            textDisplay.text = message;
        }
    }

}

