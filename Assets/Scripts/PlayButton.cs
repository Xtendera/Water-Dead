using TMPro;
using UnityEngine;

public class PlayButton : MonoBehaviour
{
    public Fader fader;
    public GameInfo gameInfo;
    public GameObject answersPage;
    public GameObject startPage;
    public TMP_InputField input1;
    public TMP_InputField input2;
    public TMP_InputField input3;
    public TMP_InputField input4;
    public GameObject errorText;
    public TurnManager turnManager;

    public void OnClick()
    {
        int playerCount = 0;
        if (input1.text != string.Empty)
        {
            if(input1.text.Length < 3 || input1.text.Length > 12)
            {
                ShowNameErr();
                return;
            }
            else
            {
                playerCount++;
            }
        }

        if (input2.text != string.Empty)
        {
            if (input2.text.Length < 3 || input2.text.Length > 12)
            {
                ShowNameErr();
                return;
            }
            else
            {
                playerCount++;
            }
        }

        if (input3.text != string.Empty)
        {
            if (input3.text.Length < 3 || input3.text.Length > 12)
            {
                ShowNameErr();
                return;
            }
            else
            {
                playerCount++;
            }
        }

        if (input4.text != string.Empty)
        {
            if (input4.text.Length < 3 || input4.text.Length > 12)
            {
                ShowNameErr();
                return;
            }
            else
            {
                playerCount++;
            }
        }
        
        if (playerCount < 2)
        {
            ShowNameErr();
            return;
        }

        QuestionManager qManager = answersPage.GetComponent<QuestionManager>();

       qManager.InitQuestion();

        gameInfo.playerNames = new string[playerCount];
        gameInfo.playerCharacters = new int[playerCount];
        gameInfo.playerCharactersChange = new float[playerCount];
        int tmpIndex = -1;

        if (input1.text != string.Empty)
        {
            tmpIndex++;
            gameInfo.playerNames[tmpIndex] = input1.text;
            gameInfo.playerCharacters[tmpIndex] = 1;
            gameInfo.playerCharactersChange[tmpIndex] = 0;
        }
        if (input2.text != string.Empty)
        {
            tmpIndex++;
            gameInfo.playerNames[tmpIndex] = input2.text;
            gameInfo.playerCharacters[tmpIndex] = 2;
            gameInfo.playerCharactersChange[tmpIndex] = 0;
        }
        if (input3.text != string.Empty)
        {
            tmpIndex++;
            gameInfo.playerNames[tmpIndex] = input3.text;
            gameInfo.playerCharacters[tmpIndex] = 3;
            gameInfo.playerCharactersChange[tmpIndex] = 0;
        }
        if (input4.text != string.Empty)
        {
            tmpIndex++;
            gameInfo.playerNames[tmpIndex] = input4.text;
            gameInfo.playerCharacters[tmpIndex] = 4;
            gameInfo.playerCharactersChange[tmpIndex] = 0;
        }

        fader.Fade();
        fader.callback = FadeCB;
    }
    void FadeCB()
    {
        // Temp. go to questions page
        answersPage.SetActive(true);
        turnManager.UpdateTurn();
        startPage.SetActive(false);
        fader.Fade();
    }

    void ShowNameErr ()
    {
        errorText.SetActive(true);
    }
}