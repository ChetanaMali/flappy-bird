using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //private static GameManager instance;
    //public static GameManager Instance { get { return instance; } }

    public Pipe pipeRef;
    //Pipe Related Variable
    public GameObject pipePrefab;
    float pipeGenerateIntervalTime = 2f;
    
    public GameObject gameOverImage;
    public GameObject restartLevelButton;

   /* private void Awake()
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
    }*/
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
    
    /*public void UpdatedScoring(int scorenum)
    {
        //score = scorenum;
        scoreText.text = score.ToString();
    }
    */


}
