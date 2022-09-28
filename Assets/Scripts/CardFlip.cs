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
    public GameObject cardFlipBtn;


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
            cardFlipBtn.SetActive(true);
            gameInfo.playerCharactersChange[gameInfo.turnIndex] -= 1.00f;

        }
        if (chance == 1)
        {
            otherTxt.text = "A large rock hits you and you fall downward!";
            otherTxtParent.SetActive(true);
            cardFlipBtn.SetActive(true);
            gameInfo.playerCharactersChange[gameInfo.turnIndex] -= 1.50f;

        }
        if (chance == 2)
        {
            otherTxt.text = "Nothing happens!";
            otherTxtParent.SetActive(true);
            cardFlipBtn.SetActive(true);

        }
    }
}
