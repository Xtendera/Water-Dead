using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerScript : MonoBehaviour
{
    public GameInfo gameInfo;
    public QuestionManager questionManager;
    public GameObject UI;
    public GameObject questions;
    public GameObject background;
    public MinigameManager mgManager;
    public GameObject character1;
    public GameObject character2;
    public GameObject character3;
    public GameObject character4;
    public void OnClick(string button)
    {
       if (gameInfo.correctAnswer == button)
        {
            // The answer is correct
        } else
        {
            // The answer is incorrect
            UI.SetActive(false);
            questions.SetActive(false);
            character1.SetActive(false);
            character2.SetActive(false);
            character3.SetActive(false);
            character4.SetActive(false);
            background.SetActive(false);
            mgManager.DoMinigame();
        }
    }
}
