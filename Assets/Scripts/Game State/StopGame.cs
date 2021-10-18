using UnityEngine;

public class StopGame : MonoBehaviour
{
    public void Stop()
    {
        Time.timeScale = 0;
    }
}