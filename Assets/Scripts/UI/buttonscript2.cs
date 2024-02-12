using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttonscript2 : MonoBehaviour
{
   
    public Text textDisplay;
    public float displayTime = 5f; 

    void Start()
    {
        textDisplay.gameObject.SetActive(false);
    }

    public void DisplayText()
    {
        
        textDisplay.gameObject.SetActive(!textDisplay.gameObject.activeSelf);

        if (textDisplay.gameObject.activeSelf)
        {
           
            string message = textDisplay.text;
            textDisplay.text = message;
            Invoke("HideTextAndEndGame", displayTime);
        }
        else
        {
            CancelInvoke("HideTextAndEndGame");
        }
    }

    void HideTextAndEndGame()
    {
        textDisplay.gameObject.SetActive(false); 
        RestartLevel(); 
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
