using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float upSpeed = 1f;
    float rotateRate = 10f;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.velocity = new Vector2(0, upSpeed);
            //rb.AddForce(transform.up * upSpeed * Time.deltaTime);
            //rb.velocity = transform.up * upSpeed * Time.deltaTime;
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioManeger.Instance.PlayDieAudio();
        Debug.Log("Play Die Audio");
        Time.timeScale = 0;       // Game Stop
        GameManager.Instance.gameOverPanel.SetActive(true);
        PlayerDead();
    }

    private void PlayerDead()
    {
        float v = transform.GetComponent<Rigidbody2D>().velocity.y;
        float rotate = Mathf.Min(Mathf.Max(-90, v * rotateRate + 60), 30);
        transform.rotation = Quaternion.Euler(0f, 0f, rotate);
    }
}
