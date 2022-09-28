using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CardFlipOk : MonoBehaviour
{
    public GameObject card1;
    public GameObject card2;
    public GameObject card3;
    public GameObject otherTxtParent;
    public MinigameManager minigameManager;
    public GameObject cardFlip;
    public GameObject cardFlipBtn;
    public void OnClickBtn()
    {
        otherTxtParent.SetActive(false);
        cardFlip.SetActive(false);
        card1.SetActive(true);
        card2.SetActive(true);
        card3.SetActive(true);
        cardFlipBtn.SetActive(false);
        minigameManager.ResetGame();
    }
}
