using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]
public class QuestionSO : ScriptableObject
{
    [TextArea(2, 6)]
    [SerializeField] string question = "Yeni soru ekle";
    [SerializeField] string[] answers = new string[4];
    [SerializeField] int correctAnswer;

    public string GetQuestion()
    {
        return question;
    }

    public int GetCorrectAnswerIndex()
    {
        return correctAnswer;
    }

    public string GetAnswer(int index)
    {
        return answers[index];
    }

    /*public class Test
    {
        QuestionSO questionSO;

        void TestA()
        {
            string questionTest = questionSO.GetQuestion();
        }

    }
    */


}

