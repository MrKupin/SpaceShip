using UnityEngine;

public class AsteridMovement : BaseTeleport
{
    [SerializeField] private float _speed;

    private void FixedUpdate()
    {
        transform.Translate(Vector2.right * _speed, Space.Self);
    }
}