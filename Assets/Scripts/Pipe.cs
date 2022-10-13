using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    //[SerializeField] GameObject pipe;
    //[SerializeField] Rigidbody2D rb2D;
    [SerializeField] float pipeSpeed = 1f;
   
    private void Update()
    {
        transform.Translate(Vector2.left * pipeSpeed * Time.deltaTime);
        Destroy(gameObject, 5f);
    }
}
