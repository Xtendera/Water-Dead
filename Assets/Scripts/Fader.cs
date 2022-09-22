using UnityEngine;

public class Fader : MonoBehaviour
{
    public Animator animator;

    public delegate void FadeCallback();  
    public FadeCallback callback;
    
    public void Fade()
    {
        animator.SetTrigger("Fade");
    }

    public void OnFadeComplete()
    {
        callback();
    }
}
