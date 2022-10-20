using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float upSpeed = 250f;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = transform.up * upSpeed * Time.deltaTime;
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        Debug.Log("Game Over!!");
        AudioManeger.Instance.PlayDieAudio();
        Debug.Log("Play Die Audio");
        //Destroy(gameObject);
        Time.timeScale = 0;       // Game Stop
        //rb.velocity = -transform.up * upSpeed * Time.deltaTime;// transform.up * upSpeed * Time.deltaTime;

    }
}
