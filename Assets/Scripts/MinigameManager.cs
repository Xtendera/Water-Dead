using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameManager : MonoBehaviour
{

    public GameObject cardFlip;
    public GameObject miniGames;
    public void DoMinigame()
    {
        miniGames.SetActive(true);
        int minigame = Random.Range(0, 1);
        if (minigame == 0)
        {
            cardFlip.SetActive(true);
        }
    }

    public void ResetGame()
    {
        miniGames.SetActive(false);

    }
}
