//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Question", menuName = "Quiz/Questions")]
public class QuizQuestions : ScriptableObject
{
    public string question;
    public string option1;
    public string option2;
    public string option3;
    public string option4;

    public string answer;
}
