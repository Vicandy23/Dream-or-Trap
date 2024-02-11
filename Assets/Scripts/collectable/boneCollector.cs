using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boneCollector : MonoBehaviour
{
    //private void OnTriggerEnter2D(Collider2D collision)
    //{


    //    if (collision.gameObject.CompareTag("Collectable"))
    //    {
    //        Destroy(collision.gameObject);
    //    }
    //}

   
    public Text collectText; // Reference to the UI Text component
    public string collectedMessage = "You just collected a bone!\n" + "Press left control to attack!"; // Default collected message
    public float displayTime = 6f; // Time to display the text

    void Start()
    {
        // Deactivate the text when the game starts
        collectText.gameObject.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Collectable"))
        {
            Destroy(collision.gameObject);
            ShowCollectText();
        }
    }

    private void ShowCollectText()
    {
        collectText.text = collectedMessage; // Set the text to display
        collectText.gameObject.SetActive(true); // Activate the UI Text
        Invoke("HideCollectText", displayTime); // Invoke method to hide the text after displayTime seconds
    }

    private void HideCollectText()
    {
        collectText.gameObject.SetActive(false); // Hide the UI Text
    }
}
