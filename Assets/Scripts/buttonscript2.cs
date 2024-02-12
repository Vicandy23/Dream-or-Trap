using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttonscript2 : MonoBehaviour
{
    //public Text textDisplay;

    //void Start()
    //{
    //    // Deactivate the text when the game starts
    //    textDisplay.gameObject.SetActive(false);
    //}

    //// This method will be called when the button is clicked
    //public void DisplayText()
    //{
    //    // Toggle the visibility of the text
    //    textDisplay.gameObject.SetActive(!textDisplay.gameObject.activeSelf);

    //    // If the text is being activated, set its content from the Text component
    //    if (textDisplay.gameObject.activeSelf)
    //    {
    //        // Get the text from the Text component attached to the UI element
    //        string message = textDisplay.text;

    //        // Set the text to display the message from the Text component
    //        textDisplay.text = message;

    //        // Start the coroutine to end the game after 5 seconds
    //        StartCoroutine(EndGameAfterDelay());
    //    }
    //    else
    //    {
    //        // Stop the coroutine if the text is being deactivated
    //        StopAllCoroutines();
    //    }
    //}

    //IEnumerator EndGameAfterDelay()
    //{
    //    yield return new WaitForSeconds(5f); // Wait for 5 seconds
    //    EndGame(); // End the game
    //}

    //void EndGame()
    //{

    //    Application.Quit();
    //}
    public Text textDisplay;
    public float displayTime = 5f; // Time to display the text before ending the game

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

            // Schedule the method to hide the text and end the game after the specified time
            Invoke("HideTextAndEndGame", displayTime);
        }
        else
        {
            // Cancel the scheduled method if the text is being deactivated
            CancelInvoke("HideTextAndEndGame");
        }
    }

    void HideTextAndEndGame()
    {
        textDisplay.gameObject.SetActive(false); // Hide the text
        RestartLevel(); // End the game
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
