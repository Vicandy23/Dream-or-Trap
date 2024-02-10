using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemymovement : MonoBehaviour
{

    public Transform[] patrolPoints;
    public float moveSpeeed = 3;
    public int patrolDestination;
    public Transform playerTransform;
    public bool isChasing;
    public float chaseDistance;

    [SerializeField] private GameObject FloatingTextPrefab;


    // Update is called once per frame
    void Update()
    {
        if (isChasing)
        {
            if (transform.position.x > playerTransform.position.x)
            {
                transform.localScale = new Vector3(1, 1, 1);
                transform.position += Vector3.left * moveSpeeed * Time.deltaTime;
            }

            if (transform.position.x < playerTransform.position.x)
            {
                transform.localScale = new Vector3(-1, 1, 1);
                transform.position += Vector3.right * moveSpeeed * Time.deltaTime;
            }
           
        }
        else
        {

            if (Vector2.Distance(transform.position, playerTransform.position) < chaseDistance)
            {
                isChasing = true;
                ShowMessage("He lies to you!");
            }

            if (patrolDestination == 0)
            {
                transform.position = Vector2.MoveTowards(transform.position, patrolPoints[0].position, moveSpeeed * Time.deltaTime);
                if (Vector2.Distance(transform.position, patrolPoints[0].position) < 0.2f)
                {
                    transform.localScale = new Vector3(-1, 1, 1);
                    patrolDestination = 1;
                }
            }

            if (patrolDestination == 1)
            {
                transform.position = Vector2.MoveTowards(transform.position, patrolPoints[1].position, moveSpeeed * Time.deltaTime);
                if (Vector2.Distance(transform.position, patrolPoints[1].position) < 0.2f)
                {
                    transform.localScale = new Vector3(1, 1, 1);
                    patrolDestination = 0;
                }
            }
        }

        void ShowMessage(string text)
        {
            if (FloatingTextPrefab)
            {
                GameObject prefab = Instantiate(FloatingTextPrefab, transform.position, Quaternion.identity);
                prefab.GetComponentInChildren<TextMesh>().text = text;
                prefab.transform.SetParent(transform);

            }

        }
        


        
    }
}