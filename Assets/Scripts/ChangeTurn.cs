using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTurn : MonoBehaviour
{
    public GameObject gameContBtn;
    public GameObject backPanel;
    public QuestionManager questionMgr;
    public GameObject questionsPage;
    public TurnManager turnMgr;
    public GameObject character1;
    public GameObject character2;
    public GameObject character3;
    public GameObject character4;
    public void OnBtnClick()
    {
        character1.SetActive(false);
        character2.SetActive(false);
        character3.SetActive(false);
        character4.SetActive(false);
        gameContBtn.SetActive(false);
        backPanel.SetActive(true);
        questionMgr.InitQuestion();
        questionsPage.SetActive(true);
        turnMgr.UpdateTurn();
    }
}
