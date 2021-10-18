using UnityEngine;

public class DisableAsteroids : MonoBehaviour
{
    public void Disable(GameObject asteroid)
    {
        asteroid.SetActive(false);
    }
}