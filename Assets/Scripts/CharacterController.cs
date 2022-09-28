using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float speed = 1.0f;
    public GameInfo gameInfo;
    public GameObject changeTurn;
    public GameObject backPanel;
    public TMP_Text victoryText;
    public GameObject char1;
    public GameObject char2;
    public GameObject char3;
    public GameObject char4;
    private Vector2 targetPosition;
    private bool isMoving = false;

    // Update is called once per frame
    void Update()
    {
        if (isMoving)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, step);
            if (new Vector2(transform.position.x, transform.position.y) == targetPosition)
            {
                if (transform.position.y < -2.71f)
                {
                    float highestValue = char1.transform.position.y;
                    string highestValueName = gameInfo.playerNames[Array.FindIndex(gameInfo.playerCharacters, row => row == 1)];
                    if (char2.transform.position.y > highestValue)
                    {
                        highestValue = char2.transform.position.y;
                        highestValueName = gameInfo.playerNames[Array.FindIndex(gameInfo.playerCharacters, row => row == 2)];
                    }
                    if (gameInfo.playerNames.Length >= 3)
                    {
                        if (char3.transform.position.y > highestValue)
                        {
                            highestValue = char3.transform.position.y;
                            highestValueName = gameInfo.playerNames[Array.FindIndex(gameInfo.playerCharacters, row => row == 3)];
                        }
                    }
                    if (gameInfo.playerNames.Length >= 4)
                    {
                        if (char4.transform.position.y > highestValue)
                        {
                            highestValue = char4.transform.position.y;
                            highestValueName = gameInfo.playerNames[Array.FindIndex(gameInfo.playerCharacters, row => row == 4)];
                        }
                    }
                    backPanel.SetActive(true);
                    victoryText.text = highestValueName + " is the winner! GG!";
                } else
                {
                    changeTurn.SetActive(true);
                    isMoving = false;
                }
            }
        }
    }
    
    public void MovePlayer()
    {
        targetPosition = new Vector2(transform.position.x, transform.position.y + gameInfo.playerCharactersChange[gameInfo.turnIndex]);
        isMoving = true;
        gameInfo.playerCharactersChange[gameInfo.turnIndex] = 0;
    }
}
