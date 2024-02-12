using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class coinCollector : MonoBehaviour
{
    private int copper = 0;
    [SerializeField] private Text cointext;

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
                // Call a method to end the game
                EndGame();
            }
        }
    }

    private void EndGame()
    {
        // Add your code here to end the game, for example:
        Debug.Log("Game Over!"); // Replace this with your game over logic
        // You might want to disable player controls, show a game over screen, etc.
    }
}

