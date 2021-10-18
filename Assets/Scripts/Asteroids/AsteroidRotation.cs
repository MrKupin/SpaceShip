using UnityEngine;

public class AsteroidRotation : BaseTeleport
{
    private void OnEnable()
    {
        transform.rotation = Quaternion.Euler(0, 0, Random.Range(0, 360));
    }
}