using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
 
    public Text textDisplay;

    //void Start()
   
    void Start()
    {
        // Deactivate the text when the game starts
        textDisplay.gameObject.SetActive(false);
    }

    // This method will be called when the button is clicked
    public void DisplayText()
    {
        // Toggle the visibility of the text
        textDisplay.gameObject.SetActive(!textDisplay.gameObject.activeSelf);

        // If the text is being activated, set its content
        if (textDisplay.gameObject.activeSelf)
        {
            textDisplay.text = "Right arrow - right movement\n" + " Left arrow - Left movement\n" + " Space - Jump";
        }
    }

}

