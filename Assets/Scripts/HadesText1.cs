using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HadesText1 : MonoBehaviour
{

    public GameObject planePrefab; // Reference to the plane prefab to spawn
    public float displayTime = 20f; // Time to display the plane

    void Start()
    {
        // Deactivate the plane when the game starts
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
        // Instantiate the plane prefab at the current position
        GameObject planeInstance = Instantiate(planePrefab, transform.position, Quaternion.identity);
        // Activate the plane
        planeInstance.SetActive(true);

        // Destroy the plane after displayTime seconds
        Destroy(planeInstance, displayTime);
    }
}
