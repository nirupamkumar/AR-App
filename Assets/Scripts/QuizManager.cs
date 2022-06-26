using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    public List<Questions> questions;
    public List<Text> options;
    public Text questionText;
    
    void Start()
    {
        
    }

    void Update()
    {
        PopulateQuestion();
    }

    private void PopulateQuestion()
    {
        List<string> randomizedAnswers = new List<string>();

        int index = Random.Range(0, questions.Count - 1);
        Questions currentQuestion = questions[index];

        questionText.text = currentQuestion.Question;
        List<string> answers = new List<string>();
        foreach (var answer in currentQuestion.Answers)
        {
            answers.Add(answer);
        }

        var random = new System.Random();

        var randomizedList = answers.OrderBy(item => random.Next()).ToList();

        for (int i = 0; i < randomizedList.Count; i++)
        {
            options[i].text = randomizedList[i]; 
        }
    }
}
