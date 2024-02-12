using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class coinCollector : MonoBehaviour
{
    private int copper = 0;
    [SerializeField] private Text cointext;
    [SerializeField] private GameObject winObject; // Reference to the GameObject to appear when the player wins

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("collectable"))
        {
            Destroy(collision.gameObject);
            copper += 2; // Increment by 2 as per your logic
            cointext.text = "Copper: " + copper;

            // Check if the player has collected 8 copper coins
            if (copper >= 8)
            {
                // Activate the win object
                winObject.SetActive(true);
            }
        }
    }
}

