using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInfo : MonoBehaviour
{
/*    public string player1Name;
    public float player1Change;
    public string player2Name;
    public float player2Change;
    public string player3Name;
    public float player3Change;
    public string player4Name;
    public float player4Change;*/

    public string[] playerNames;
    public int[] playerCharacters;
    public float[] playerCharactersChange;

    public bool isOnExtra = false;
    public int[] importantAnsweredQuestions;
    public int[] extraAnsweredQuestions;
    public int turnIndex = -1;

    public string correctAnswer;

}
