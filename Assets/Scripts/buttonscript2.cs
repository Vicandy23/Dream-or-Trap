using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class buttonscript2 : MonoBehaviour
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

            // Start the coroutine to end the game after 5 seconds
            StartCoroutine(EndGameAfterDelay());
        }
        else
        {
            // Stop the coroutine if the text is being deactivated
            StopAllCoroutines();
        }
    }

    IEnumerator EndGameAfterDelay()
    {
        yield return new WaitForSeconds(5f); // Wait for 5 seconds
        EndGame(); // End the game
    }

    void EndGame()
    {
        // Add code here to end the game
        Debug.Log("Game Ended");
        // Example: Application.Quit(); to quit the application
    }

}
