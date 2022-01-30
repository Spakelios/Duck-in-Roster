using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI Scoretext;

    private int score;



    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }

        Scoretext.text = score.ToString() ;


    }

    public void ChangeScore(int dropValue)
    {
        score += dropValue;
        Scoretext.text =  score.ToString() ;
    }
}