using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public Text textDisplay;

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

        // If the text is being activated, set its content from the Text component
        if (textDisplay.gameObject.activeSelf)
        {
            // Get the text from the Text component attached to the UI element
            string message = textDisplay.text;

            // Set the text to display the message from the Text component
            textDisplay.text = message;
        }
    }

}

