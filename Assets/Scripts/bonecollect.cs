using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bonecollect : MonoBehaviour
{
    private int bone= 0;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.gameObject.CompareTag("collectable"))
        {
            Destroy(collision.gameObject);
            bone = bone++;
            
        }
    }
}
