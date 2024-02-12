using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGameobject : MonoBehaviour
{
    public float delay = 50f;

    void Start()
    {
        Debug.Log("DestroyAfterDelay script started.");
        
        Destroy(gameObject, delay);
    }
}
