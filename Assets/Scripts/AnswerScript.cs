using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerScript : MonoBehaviour
{
    public GameInfo gameInfo;
    public void OnClick(string button)
    {
       if (gameInfo.correctAnswer == button)
        {
            // The answer is correct


        } else
        {
            // The answer is incorrect
        }
    }
}
