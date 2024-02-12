using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class hadestext : MonoBehaviour
{
    public GameObject planePrefab; 
    public float displayTime = 20f; 

    void Start()
    {
        
        planePrefab.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Hades"))
        {
            ShowPlane();
        }
    }

    private void ShowPlane()
    {
        
        GameObject planeInstance = Instantiate(planePrefab, transform.position, Quaternion.identity);
       
        planeInstance.SetActive(true);
        Destroy(planeInstance, displayTime);
    }
}
