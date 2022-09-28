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
    public GameObject backpanel;
    public CharacterController player1Controller;
    public CharacterController player2Controller;
    public CharacterController player3Controller;
    public CharacterController player4Controller;

    public void OnClick(string button)
    {
       if (gameInfo.correctAnswer == button)
        {
            UI.SetActive(true);
            background.SetActive(true);
            questions.SetActive(false);
            backpanel.SetActive(false);
            if (gameInfo.playerCharacters[gameInfo.turnIndex] == 1)
            {
                character1.SetActive(true);
                player1Controller.MovePlayer();
            }
            if (gameInfo.playerCharacters[gameInfo.turnIndex] == 2)
            {
                character2.SetActive(true);
                player2Controller.MovePlayer();
            }
            if (gameInfo.playerCharacters[gameInfo.turnIndex] == 3)
            {
                character3.SetActive(true);
                player3Controller.MovePlayer();
            }
            if (gameInfo.playerCharacters[gameInfo.turnIndex] == 4)
            {
                character4.SetActive(true);
                player4Controller.MovePlayer();
            }
            // The answer is correct
        } else
        {
            // The answer is incorrect
            UI.SetActive(false);
            questions.SetActive(false);
            backpanel.SetActive(false);
            character1.SetActive(false);
            character2.SetActive(false);
            character3.SetActive(false);
            character4.SetActive(false);
            background.SetActive(false);
            mgManager.DoMinigame();
        }
    }
}
