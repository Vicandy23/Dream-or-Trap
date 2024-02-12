using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boneCollector : MonoBehaviour
{
    

   
    public Text collectText; 
    public string collectedMessage = "You just collected a bone!\n" + "Press left control to attack!"; 
    public float displayTime = 6f; 

    void Start()
    {
        
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
        collectText.text = collectedMessage; 
        collectText.gameObject.SetActive(true); 
        Invoke("HideCollectText", displayTime); 
    }

    private void HideCollectText()
    {
        collectText.gameObject.SetActive(false); 
    }
}
