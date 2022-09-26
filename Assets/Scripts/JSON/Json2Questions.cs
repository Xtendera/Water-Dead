using UnityEngine;

public class Json2Questions : MonoBehaviour
{
    public TextAsset importantQuestionsFile;
    public TextAsset extraQuestionsFile;

    public Questions GetImportantQuestions()
    {
        Questions questions = JsonUtility.FromJson<Questions>(importantQuestionsFile.text);
        return questions;
    }
    
    public Questions GetExtraQuestions()
    {
        Questions questions = JsonUtility.FromJson<Questions>(extraQuestionsFile.text);
        return questions;
    }
}
