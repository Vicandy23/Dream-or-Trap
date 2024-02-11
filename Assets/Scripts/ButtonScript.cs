using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
 
    public Text textDisplay;

    // This method will be called when the button is clicked
    public void DisplayText()
    {
        textDisplay.text = "Right arrow - right movement" +
            " Left arrow - Left movement" +
            " Space - Jump";
    }
}

