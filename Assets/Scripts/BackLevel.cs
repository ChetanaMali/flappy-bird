using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(1);
        //Time.timeScale = 1;
    }
    public void BackToTheMenu()
    {
        SceneManager.LoadScene(0);
        //Time.timeScale = 1;
    }
}
