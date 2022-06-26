using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Question", menuName = "Quiz/Questions")]
public class Questions : ScriptableObject
{
    public string Question;
    public List<string> Answers;
    public int CorrectAnswerIndex;

    public bool IsAnswerCorrect(string answer)
    {
        string correctAnswer = Answers[CorrectAnswerIndex];

        return string.Equals(answer, correctAnswer);
    }
}
