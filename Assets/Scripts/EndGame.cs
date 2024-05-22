using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndGame : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI finalScoreText;

    Score score;
    void Awake()
    {
        score = FindAnyObjectByType<Score>();
    }

    public void ShowFinalScore()
    {
        finalScoreText.text = score.CalculateScore() + "%";
    }


}
