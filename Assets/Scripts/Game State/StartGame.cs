using UnityEngine;

public class StartGame : MonoBehaviour
{
    [SerializeField] private Animator _animatorStart;

    public void Start_Game()
    {
        Time.timeScale = 1;
        _animatorStart.SetTrigger("StartGame");
    }
}