using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGameobject : MonoBehaviour
{
    public float delay = 50f;

    void Start()
    {
        Debug.Log("DestroyAfterDelay script started.");
        // Call the Destroy method after the specified delay
        Destroy(gameObject, delay);
    }
}
