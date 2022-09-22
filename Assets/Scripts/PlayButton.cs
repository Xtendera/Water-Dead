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

        gameInfo.player1Name = input1.text;
        gameInfo.player2Name = input2.text;
        gameInfo.player3Name = input3.text;
        gameInfo.player4Name = input4.text;

        fader.Fade();
        fader.callback = FadeCB;
    }
    void FadeCB()
    {
        // Temp. go to questions page
        answersPage.SetActive(true);
        startPage.SetActive(false);
        fader.Fade();
    }

    void ShowNameErr ()
    {
        errorText.SetActive(true);
    }
}