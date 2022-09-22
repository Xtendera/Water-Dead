using System;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class QuestionManager : MonoBehaviour
{
    public Json2Questions json2Questions;
    public GameInfo gameInfo;
    public TMP_Text questionText;
    public TMP_Text answer1;
    public TMP_Text answer2;
    public TMP_Text answer3;
    public TMP_Text answer4;
    public void InitQuestion()
    {
        Questions questions = json2Questions.GetQuestions();
        if (gameInfo.answeredQuestions == null)
        {
            gameInfo.answeredQuestions = new int[questions.questions.Length];
        }
        bool isComplete = false;
        Question randomQuestion = null;
        while (isComplete == false)
        {
            int randomQuestionIndex = Random.Range(0,questions.questions.Length);
            if (!Array.Exists(gameInfo.answeredQuestions, element => element == randomQuestionIndex))
            {
                isComplete = true;
                randomQuestion = questions.questions[randomQuestionIndex];
            }
        }
        questionText.text = randomQuestion.question;
        if (randomQuestion.answers.Length == 4)
        {
            int loopIndex = 0;
            int[] questionMix = new int[4];
            while (loopIndex != 3)
            {
                int randomNumber = Random.Range(0, 4);
                if (!Array.Exists(questionMix, element => element == randomNumber))
                {
                    questionMix[loopIndex] = randomNumber;
                    loopIndex++;

                }
            }
            answer1.text = randomQuestion.answers[questionMix[0]];
            answer2.text = randomQuestion.answers[questionMix[1]];
            answer3.text = randomQuestion.answers[questionMix[2]];
            answer4.text = randomQuestion.answers[questionMix[3]];
        }

    }
}
