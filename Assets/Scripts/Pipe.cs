using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    //[SerializeField] GameObject pipe;
    //[SerializeField] Rigidbody2D rb2D;
    [SerializeField] float pipeSpeed = 1f;
    float timeToDestroy = 7f;
   
    private void Update()
    {
        transform.Translate(Vector2.left * pipeSpeed * Time.deltaTime);
        Destroy(gameObject, timeToDestroy);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //player score will be increase when player pass through the pipe
        Debug.Log("Score Increse!!");
        GameManager.Instance.Scoring();
    }
    
}
