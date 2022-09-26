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
        if (gameInfo.turnIndex == 0)
        {
            for (int i = 1; i <= 4; i++)
            {
                if (i == 1)
                {
                    if (gameInfo.player1Name != null)
                    {
                        turnTxt.text = gameInfo.player1Name + "'s turn";
                        gameInfo.turnIndex = 1;
                        break;
                    }
                }
                if (i == 2)
                {
                    if (gameInfo.player2Name != null)
                    {
                        turnTxt.text = gameInfo.player2Name + "'s turn";
                        gameInfo.turnIndex = 2;
                        break;
                    }
                }
                if (i == 3)
                {
                    if (gameInfo.player3Name != null)
                    {
                        turnTxt.text = gameInfo.player3Name + "'s turn";
                        gameInfo.turnIndex = 3;
                        break;
                    }
                }
                if (i == 4)
                {
                    if (gameInfo.player4Name != null)
                    {
                        turnTxt.text = gameInfo.player4Name + "'s turn";
                        gameInfo.turnIndex = 4;
                        break;
                    }
                }
            }
        }
        if (gameInfo.turnIndex == 1)
        {
            for (int i = 2; i <= 4; i++)
            {
                if (i == 1)
                {
                    if (gameInfo.player1Name != null)
                    {
                        turnTxt.text = gameInfo.player1Name + "'s turn";
                        gameInfo.turnIndex = 1;
                        break;
                    }
                }
                if (i == 2)
                {
                    if (gameInfo.player2Name != null)
                    {
                        turnTxt.text = gameInfo.player2Name + "'s turn";
                        gameInfo.turnIndex = 2;
                        break;
                    }
                }
                if (i == 3)
                {
                    if (gameInfo.player3Name != null)
                    {
                        turnTxt.text = gameInfo.player3Name + "'s turn";
                        gameInfo.turnIndex = 3;
                        break;
                    }
                }
                if (i == 4)
                {
                    if (gameInfo.player4Name != null)
                    {
                        turnTxt.text = gameInfo.player4Name + "'s turn";
                        gameInfo.turnIndex = 4;
                        break;
                    }
                }
            }
        }
        if (gameInfo.turnIndex == 2)
        {
            for (int i = 3; i <= 4; i++)
            {
                if (i == 1)
                {
                    if (gameInfo.player1Name != null)
                    {
                        turnTxt.text = gameInfo.player1Name + "'s turn";
                        gameInfo.turnIndex = 1;
                        break;
                    }
                }
                if (i == 2)
                {
                    if (gameInfo.player2Name != null)
                    {
                        turnTxt.text = gameInfo.player2Name + "'s turn";
                        gameInfo.turnIndex = 2;
                        break;
                    }
                }
                if (i == 3)
                {
                    if (gameInfo.player3Name != null)
                    {
                        turnTxt.text = gameInfo.player3Name + "'s turn";
                        gameInfo.turnIndex = 3;
                        break;
                    }
                }
                if (i == 4)
                {
                    if (gameInfo.player4Name != null)
                    {
                        turnTxt.text = gameInfo.player4Name + "'s turn";
                        gameInfo.turnIndex = 4;
                        break;
                    }
                }
            }
        }
        if (gameInfo.turnIndex == 3)
        {
            for (int i = 4; i <= 4; i++)
            {
                if (i == 1)
                {
                    if (gameInfo.player1Name != null)
                    {
                        turnTxt.text = gameInfo.player1Name + "'s turn";
                        gameInfo.turnIndex = 1;
                        break;
                    }
                }
                if (i == 2)
                {
                    if (gameInfo.player2Name != null)
                    {
                        turnTxt.text = gameInfo.player2Name + "'s turn";
                        gameInfo.turnIndex = 2;
                        break;
                    }
                }
                if (i == 3)
                {
                    if (gameInfo.player3Name != null)
                    {
                        turnTxt.text = gameInfo.player3Name + "'s turn";
                        gameInfo.turnIndex = 3;
                        break;
                    }
                }
                if (i == 4)
                {
                    if (gameInfo.player4Name != null)
                    {
                        turnTxt.text = gameInfo.player4Name + "'s turn";
                        gameInfo.turnIndex = 4;
                        break;
                    }
                }
            }
        }
        if (gameInfo.turnIndex == 4)
        {
            for (int i = 1; i <= 4; i++)
            {
                if (i == 1)
                {
                    if (gameInfo.player1Name != null)
                    {
                        turnTxt.text = gameInfo.player1Name + "'s turn";
                        gameInfo.turnIndex = 1;
                        break;
                    }
                }
                if (i == 2)
                {
                    if (gameInfo.player2Name != null)
                    {
                        turnTxt.text = gameInfo.player2Name + "'s turn";
                        gameInfo.turnIndex = 2;
                        break;
                    }
                }
                if (i == 3)
                {
                    if (gameInfo.player3Name != null)
                    {
                        turnTxt.text = gameInfo.player3Name + "'s turn";
                        gameInfo.turnIndex = 3;
                        break;
                    }
                }
                if (i == 4)
                {
                    if (gameInfo.player4Name != null)
                    {
                        turnTxt.text = gameInfo.player4Name + "'s turn";
                        gameInfo.turnIndex = 4;
                        break;
                    }
                }
            }
        }
        InitGameElements();
    }
    void InitGameElements()
    {
        if (gameInfo.turnIndex == 1)
        {
            character1.SetActive(true);
        }
        if (gameInfo.turnIndex == 2)
        {
            character2.SetActive(true);
        }
        if (gameInfo.turnIndex == 3)
        {
            character3.SetActive(true);
        }
        if (gameInfo.turnIndex == 4)
        {
            character4.SetActive(true);
        }

    }
}
