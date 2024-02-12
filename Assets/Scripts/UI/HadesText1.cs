using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HadesText1 : MonoBehaviour
{

    public GameObject planePrefab; 
    public float displayTime = 20f; 

    void Start()
    {

        planePrefab.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("hades"))
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
