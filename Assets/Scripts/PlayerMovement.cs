using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float upSpeed = 200f;
    [SerializeField] GameManager gameManeger;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //rb.AddForce(transform.up * upSpeed * Time.deltaTime);
            rb.velocity = transform.up * upSpeed * Time.deltaTime;
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if()
        
        Debug.Log("Game Over!!");
        AudioManeger.Instance.Play(Sounds.die);
        //AudioManeger.Instance.PlayDieAudio();
        Debug.Log("Play Die Audio");
        //Destroy(gameObject);
        Time.timeScale = 0;       // Game Stop
        gameManeger.gameOverImage.SetActive(true);
        gameManeger.restartLevelButton.SetActive(true);
        //rb.velocity = -transform.up * upSpeed * Time.deltaTime;// transform.up * upSpeed * Time.deltaTime;

    }
}
