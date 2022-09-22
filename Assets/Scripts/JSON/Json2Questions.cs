using UnityEngine;

public class Json2Questions : MonoBehaviour
{
    public TextAsset questionsFile;

    public Questions GetQuestions()
    {
        Questions questions = JsonUtility.FromJson<Questions>(questionsFile.text);
        return questions;
    }
}
