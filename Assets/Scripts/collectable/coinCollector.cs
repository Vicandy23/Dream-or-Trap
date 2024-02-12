using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class coinCollector : MonoBehaviour
{
    private int copper = 0;
    [SerializeField] private Text cointext;
    [SerializeField] private GameObject winObject; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("collectable"))
        {
            Destroy(collision.gameObject);
            copper += 2; 
            cointext.text = "Copper: " + copper;

           
            if (copper >= 8)
            {
               
                winObject.SetActive(true);
            }
        }
    }
}

