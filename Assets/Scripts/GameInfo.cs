using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInfo : MonoBehaviour
{
    public string player1Name;
    public string player2Name;
    public string player3Name;
    public string player4Name;

    public bool isOnExtra = false;
    public int[] importantAnsweredQuestions;
    public int[] extraAnsweredQuestions;
    public int turnIndex = 0;

    public string correctAnswer;

}
