using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deathnotification : MonoBehaviour
{
    public Text deathText; 

    void Start()
    {
        
        deathText.gameObject.SetActive(false);
    }

    
    public void ShowDeathMessage()
    {
        deathText.gameObject.SetActive(true); 
        deathText.text = "You died"; 
    }
}
