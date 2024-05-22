using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

    Quiz quiz;
    EndGame endGame;


    void Awake()
    {
        quiz = FindAnyObjectByType<Quiz>();
        endGame = FindAnyObjectByType<EndGame>();
    }

    void Start()
    {
        quiz.gameObject.SetActive(true);
        endGame.gameObject.SetActive(false);
    }

    void Update()
    {
        if (quiz.isComplete)
        {
            quiz.gameObject.SetActive(false); endGame.gameObject.SetActive(true);
            endGame.ShowFinalScore();
        }
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


}

