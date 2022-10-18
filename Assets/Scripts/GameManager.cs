using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance { get { return instance; } }

    //Pipe Related Variable
    [SerializeField] GameObject pipePrefab;
    float pipeGenerateIntervalTime = 2f;

    //Scoring Variable
    [SerializeField] int score = 0;
    

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
            Instantiate(pipePrefab, new Vector3(3f,Random.Range( 1,2), 0), Quaternion.identity);
        }
        
    }
    public void Scoring()
    {
        score++;
        UIManeger.Instance.UpdatedScoring(score);
    }

}
