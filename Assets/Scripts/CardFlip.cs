using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CardFlip : MonoBehaviour
{
    public GameObject card1;
    public GameObject card2;
    public GameObject card3;
    public TMP_Text otherTxt;
    public GameObject otherTxtParent;
    public GameInfo gameInfo;
    public MinigameManager minigameManager;
    public GameObject cardFlip;

    private bool isCounting;
    private float timeRemaining;

    private void OnMouseUp()
    {
        card1.SetActive(false);
        card2.SetActive(false);
        card3.SetActive(false);

        int chance = Random.Range(0, 3);
        if (chance == 0)
        {
            otherTxt.text = "A small rock hits you and you fall downward!";
            otherTxtParent.SetActive(true);
            timeRemaining = 2.0f;
            isCounting = true;
            if (gameInfo.turnIndex == 1)
            {
                gameInfo.player1Change -= 1.00f;
            }
            if (gameInfo.turnIndex == 2)
            {
                gameInfo.player2Change -= 1.00f;
            }
            if (gameInfo.turnIndex == 3)
            {
                gameInfo.player3Change -= 1.00f;
            }
            if (gameInfo.turnIndex == 4)
            {
                gameInfo.player4Change -= 1.00f;
            }

        }
        if (chance == 1)
        {
            otherTxt.text = "A large rock hits you and you fall downward!";
            otherTxtParent.SetActive(true);
            timeRemaining = 2.0f;
            isCounting = true;
            if (gameInfo.turnIndex == 1)
            {
                gameInfo.player1Change -= 1.50f;
            }
            if (gameInfo.turnIndex == 2)
            {
                gameInfo.player2Change -= 1.50f;
            }
            if (gameInfo.turnIndex == 3)
            {
                gameInfo.player3Change -= 1.50f;
            }
            if (gameInfo.turnIndex == 4)
            {
                gameInfo.player4Change -= 1.50f;
            }

        }
        if (chance == 2)
        {
            otherTxt.text = "Nothing happens!";
            otherTxtParent.SetActive(true);
            timeRemaining = 2.0f;
            isCounting = true;

        }
    }

    void Update()
    {
        Debug.Log(timeRemaining);
        if (isCounting)
        {
            if (timeRemaining > 0)
            {
                Debug.Log(timeRemaining);
                timeRemaining -= Time.deltaTime;
            } else
            {
                otherTxtParent.SetActive(false);
                cardFlip.SetActive(false);
                card1.SetActive(true);
                card2.SetActive(true);
                card3.SetActive(true);
                minigameManager.ResetGame();
                timeRemaining = 0;
                isCounting = false;
            }
        }
    }
}
