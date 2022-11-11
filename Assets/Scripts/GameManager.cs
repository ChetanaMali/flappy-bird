using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance { get { return instance; } }

    public GameObject pipePrefab;
    float pipeGenerateIntervalTime = 2f;
    public Text scoreText;
    public int score = 0;
    public GameObject gameOverPanel;
    public Text finalScore;
    

   private void Awake()
    {
        if(instance == null)
        {
            //in singlton only one object is there for whole class
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        StartCoroutine(PipeSpawn());
    }

    IEnumerator PipeSpawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(pipeGenerateIntervalTime);
            Instantiate(pipePrefab, new Vector3(3f,Random.Range( 0.6f, -0.6f), 0), Quaternion.identity);
        }
        
    }

    public void Scoring()
    {
        score++;
        scoreText.text = score.ToString();
        finalScore.text = score.ToString();
    }



}
