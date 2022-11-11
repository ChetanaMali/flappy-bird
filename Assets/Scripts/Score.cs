using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public Text hightScore;
    public int score = 0;
    private void Start()
    {
        hightScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        Debug.Log(PlayerPrefs.GetInt("HighScore", 0));
    }
    public void HIghScoring()
    {
       
        
        //High score mechanism
        if (score > PlayerPrefs.GetInt("HighScore", 0))
        {
            
            PlayerPrefs.SetInt("HighScore", score);
            hightScore.text = score.ToString();   
        }

    }
    public void Scoring()
    {
        score++;
        scoreText.text = score.ToString();
    }

}
