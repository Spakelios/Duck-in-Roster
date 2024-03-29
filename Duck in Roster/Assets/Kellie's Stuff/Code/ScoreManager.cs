using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI Scoretext;
    public TextMeshProUGUI FinalScore;
    public TextMeshProUGUI failedScore;
    public static int score;
   


    void Start()
    {
        score = 0;
        
        if (instance == null)
        {
            instance = this;
        }

        Scoretext.text = score.ToString() ;
        FinalScore.text = score.ToString();
        failedScore.text = score.ToString();


    }

    public void ChangeScore(int dropValue)
    {
        score += dropValue;
        Scoretext.text =  score.ToString() ;
        FinalScore.text = score.ToString();
        failedScore.text = score.ToString();

    }
}