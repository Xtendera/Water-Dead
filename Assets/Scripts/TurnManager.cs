using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TurnManager : MonoBehaviour
{
    public TMP_Text turnTxt;
    public GameInfo gameInfo;
    public GameObject character1;
    public GameObject character2;
    public GameObject character3;
    public GameObject character4;

    public void UpdateTurn()
    {
        if (gameInfo.turnIndex + 1 == gameInfo.playerNames.Length)
        {
            gameInfo.turnIndex = 0;
        } else
        {
            gameInfo.turnIndex++;
        }
        turnTxt.text = gameInfo.playerNames[gameInfo.turnIndex] + "'s turn";
        InitGameElements();
    }
    void InitGameElements()
    {
        if (gameInfo.playerCharacters[gameInfo.turnIndex] == 1)
        {
            character1.SetActive(true);
        }
        if (gameInfo.playerCharacters[gameInfo.turnIndex] == 2)
        {
            character2.SetActive(true);
        }
        if (gameInfo.playerCharacters[gameInfo.turnIndex] == 3)
        {
            character3.SetActive(true);
        }
        if (gameInfo.playerCharacters[gameInfo.turnIndex] == 4)
        {
            character4.SetActive(true);
        }
    }
}
