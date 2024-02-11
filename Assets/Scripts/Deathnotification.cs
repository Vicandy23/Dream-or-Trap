using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deathnotification : MonoBehaviour
{
    public Text deathText; // Reference to the UI Text object

    void Start()
    {
        // Deactivate the deathText when the game starts
        deathText.gameObject.SetActive(false);
    }

    // Call this function whenever the player dies
    public void ShowDeathMessage()
    {
        deathText.gameObject.SetActive(true); // Activate the deathText
        deathText.text = "You died"; // Set the text to "You died"
    }
}
