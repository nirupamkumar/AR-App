using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    public QuizQuestions questions;

    public Text questionText;
    public Text optionText1;
    public Text optionText2;
    public Text optionText3;
    public Text optionText4;

    // Start is called before the first frame update
    void Start()
    {
        questionText.text = questions.question;
        optionText1.text = questions.option1;
        optionText2.text = questions.option2;
        optionText3.text = questions.option3;
        optionText4.text = questions.option4;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
