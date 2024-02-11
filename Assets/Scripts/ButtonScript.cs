using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
 
    public Text textDisplay;

    void Start()
    {
        // Deactivate the deathText when the game starts
        textDisplay.gameObject.SetActive(false);
    }
    // This method will be called when the button is clicked
    public void DisplayText()
    {
        textDisplay.gameObject.SetActive(true);
        textDisplay.text = "Right arrow - right movement" +
            " Left arrow - Left movement" +
            " Space - Jump";
    }
}

