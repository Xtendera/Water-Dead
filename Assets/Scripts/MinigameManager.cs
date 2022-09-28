using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameManager : MonoBehaviour
{

    public GameObject cardFlip;
    public GameObject TIAR;
    public GameObject miniGames;
    public GameObject background;
    public GameObject UI;
    public GameInfo gameInfo;
    public GameObject character1;
    public GameObject character2;
    public GameObject character3;
    public GameObject character4;
    public CharacterController player1Controller;
    public CharacterController player2Controller;
    public CharacterController player3Controller;
    public CharacterController player4Controller;
    public void DoMinigame()
    {
        miniGames.SetActive(true);
        int minigame = Random.Range(0, 2);
        if (minigame == 0)
        {
            cardFlip.SetActive(true);
        }
        if (minigame == 1)
        {
            TIAR.SetActive(true);
        }
    }

    public void ResetGame()
    {
        miniGames.SetActive(false);
        UI.SetActive(true);
        background.SetActive(true);
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
    }
}
