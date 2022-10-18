using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManeger : MonoBehaviour
{
    private static UIManeger instance;
    public static UIManeger Instance  { get { return instance; } }

    [SerializeField] Text scoreText;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }    

    public void UpdatedScoring(int score)
    {
        scoreText.text = score.ToString();
    }
}
