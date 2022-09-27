using System;
using System.Linq;
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
    public GameObject answer4Parent;
    public GameObject answer3Parent;


    public void InitQuestion()
    {

        answer3Parent.SetActive(true);
        answer4Parent.SetActive(true);

        if (gameInfo.importantAnsweredQuestions.Length == 0)
        {
            gameInfo.importantAnsweredQuestions = Enumerable.Repeat(-1, json2Questions.GetImportantQuestions().questions.Length).ToArray();
        }
        if (gameInfo.extraAnsweredQuestions.Length == 0)
        {
            gameInfo.extraAnsweredQuestions = Enumerable.Repeat(-1, json2Questions.GetExtraQuestions().questions.Length).ToArray();
        }

        Questions questions = null;

        if (!gameInfo.isOnExtra)
        {
            int counter = 0;
            foreach (int i in gameInfo.importantAnsweredQuestions)
            {
                if (i == -1)
                {
                    counter++;
                }
            }
            if (counter == 0)
            {
                gameInfo.isOnExtra = true;
                questions = json2Questions.GetExtraQuestions();
            } else
            {
                questions = json2Questions.GetImportantQuestions();
            }

        } else
        {
            questions = json2Questions.GetExtraQuestions();
        }


        bool isComplete = false;
        Question randomQuestion = null;
        while (isComplete == false)
        {
            int randomQuestionIndex = Random.Range(0,questions.questions.Length);
            if (!gameInfo.isOnExtra)
            {
                if (!Array.Exists(gameInfo.importantAnsweredQuestions, element => element == randomQuestionIndex))
                {
                    isComplete = true;
                    randomQuestion = questions.questions[randomQuestionIndex];
                    int i = 0;
                    while (i < gameInfo.importantAnsweredQuestions.Length)
                    {
                        if (gameInfo.importantAnsweredQuestions[0] == -1)
                        {
                            gameInfo.importantAnsweredQuestions[i] = randomQuestionIndex;
                            break;
                        }
                    }
                }
            }
            if (gameInfo.isOnExtra)
            {
                if (!Array.Exists(gameInfo.extraAnsweredQuestions, element => element == randomQuestionIndex))
                {
                    isComplete = true;
                    randomQuestion = questions.questions[randomQuestionIndex];
                    int i = 0;
                    while (i < gameInfo.extraAnsweredQuestions.Length)
                    {
                        if (gameInfo.extraAnsweredQuestions[0] == -1)
                        {
                            gameInfo.extraAnsweredQuestions[i] = randomQuestionIndex;
                            break;
                        }
                    }

                }
            }
        }
        questionText.text = randomQuestion.question;
        if (randomQuestion.answers.Length == 4)
        {
            int loopIndex = 0;
            int[] questionMix = new int[4];
            questionMix[0] = -1;
            questionMix[1] = -1;
            questionMix[2] = -1;
            questionMix[3] = -1;
            while (loopIndex < 4)
            {
                int randomNumber = Random.Range(0, 4);
                if (!Array.Exists(questionMix, element => element == randomNumber))
                {
                    questionMix[loopIndex] = randomNumber;
                    loopIndex++;
                }
            }
            int index = Array.FindIndex(questionMix, row => row == 0);
            if (index == 0)
            {
                gameInfo.correctAnswer = "A";
            }
            if (index == 1)
            {
                gameInfo.correctAnswer = "B";
            }
            if (index == 2)
            {
                gameInfo.correctAnswer = "C";
            }
            if (index == 3)
            {
                gameInfo.correctAnswer = "D";
            }
            
            answer1.text = randomQuestion.answers[questionMix[0]];
            answer2.text = randomQuestion.answers[questionMix[1]];
            answer3.text = randomQuestion.answers[questionMix[2]];
            answer4.text = randomQuestion.answers[questionMix[3]];
        }

        if (randomQuestion.answers.Length == 3)
        {
            int loopIndex = 0;
            int[] questionMix = new int[3];
            questionMix[0] = -1;
            questionMix[1] = -1;
            questionMix[2] = -1;
            while (loopIndex < 3)
            {
                int randomNumber = Random.Range(0, 3);
                if (!Array.Exists(questionMix, element => element == randomNumber))
                {
                    questionMix[loopIndex] = randomNumber;
                    loopIndex++;

                }
            }
            int index = Array.FindIndex(questionMix, row => row == 0);
            if (index == 0)
            {
                gameInfo.correctAnswer = "A";
            }
            if (index == 1)
            {
                gameInfo.correctAnswer = "B";
            }
            if (index == 2)
            {
                gameInfo.correctAnswer = "C";
            }
            answer1.text = randomQuestion.answers[questionMix[0]];
            answer2.text = randomQuestion.answers[questionMix[1]];
            answer3.text = randomQuestion.answers[questionMix[2]];
            answer4Parent.SetActive(false);
        }

        if (randomQuestion.answers.Length == 2)
        {
            int loopIndex = 0;
            int[] questionMix = new int[2];
            questionMix[0] = -1;
            questionMix[1] = -1;
            while (loopIndex < 2)
            {
                int randomNumber = Random.Range(0, 2);
                if (!Array.Exists(questionMix, element => element == randomNumber))
                {
                    questionMix[loopIndex] = randomNumber;
                    loopIndex++;

                }
            }
            int index = Array.FindIndex(questionMix, row => row == 0);
            if (index == 0)
            {
                gameInfo.correctAnswer = "A";
            }
            if (index == 1)
            {
                gameInfo.correctAnswer = "B";
            }
            answer1.text = randomQuestion.answers[questionMix[0]];
            answer2.text = randomQuestion.answers[questionMix[1]];
            answer4Parent.SetActive(false);
            answer3Parent.SetActive(false);
        }

    }
}
