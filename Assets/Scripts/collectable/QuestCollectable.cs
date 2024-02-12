using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestCollectable : MonoBehaviour
{

    public Text collectText; 
    public string collectedMessage = "Its so lonely here.. Hades hurts me all the time.. \n" 
        + "I had only 4 coppers.. Now I cant pass the river and go to the underworld\n"
        +"I am stuck here between life and death and i cant leave.."; 
    public float displayTime = 6f; 

    void Start()
    {
        
        collectText.gameObject.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Quest"))
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
