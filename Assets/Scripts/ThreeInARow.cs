using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class ThreeInARow : MonoBehaviour
{
    public TMP_Text penaltyTxt;
    public TMP_Text Block1;
    public TMP_Text Block2;
    public TMP_Text Block3;
    public TMP_Text rolesTxt;
    public GameInfo gameInfo;
    public GameObject rolesBtn;
    public GameObject TIAR;
    public MinigameManager minigameManager;

    private int attemptsLeft = 3;
    private int penalty = -1;

    public void onRoleClicked()
    {
        int randomNumber1 = Random.Range(0, 2);
        int randomNumber2 = Random.Range(0, 2);
        int randomNumber3 = Random.Range(0, 2);
        if (randomNumber1 == 0)
        {
            Block1.text = "X";
        }
        if (randomNumber1 == 1)
        {
            Block1.text = "+";
        }
        if (randomNumber1 == 2)
        {
            Block1.text = "=";
        }
        if (randomNumber2 == 0)
        {
            Block2.text = "X";
        }
        if (randomNumber2 == 1)
        {
            Block2.text = "+";
        }
        if (randomNumber2 == 2)
        {
            Block2.text = "=";
        }
        if (randomNumber3 == 0)
        {
            Block3.text = "X";
        }
        if (randomNumber3 == 1)
        {
            Block3.text = "+";
        }
        if (randomNumber3 == 2)
        {
            Block3.text = "=";
        }
        if (randomNumber1 == randomNumber2 && randomNumber2 == randomNumber3)
        {
            penalty = 0;
            penaltyTxt.text = "Penalty: 0x";
            rolesTxt.text = "";
            rolesBtn.SetActive(false);
        } else
        {
            penalty -= 1;
            penaltyTxt.text = "Penalty:" + penalty + "x";
            attemptsLeft -= 1;
            rolesTxt.text = attemptsLeft + " Attempts left";
            if (attemptsLeft == 0)
            {
                rolesBtn.SetActive(false);
            }
        }
    }
    public void doneBtnClicked()
    {
        gameInfo.playerCharactersChange[gameInfo.turnIndex] += penalty;
        penalty = -1;
        penaltyTxt.text = "Penalty: -1x";
        rolesTxt.text = "3 Attempts left";
        attemptsLeft = 3;
        rolesBtn.SetActive(true);
        Block1.text = "";
        Block2.text = "";
        Block3.text = "";
        TIAR.SetActive(false);
        minigameManager.ResetGame();
    }
}
