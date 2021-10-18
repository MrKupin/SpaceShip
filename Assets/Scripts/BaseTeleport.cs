using UnityEngine;

public abstract class BaseTeleport : MonoBehaviour
{
    private Vector2 _position;

    void Update()
    {
        _position = Camera.main.WorldToScreenPoint(transform.position);
        if (_position.x < -40)
        {
            transform.position = new Vector2(-transform.position.x - 1, transform.position.y);
        }
        else if (_position.x > Screen.width + 40)
        {
            transform.position = new Vector2(-transform.position.x + 1, transform.position.y);
        }
        else if (_position.y < -40)
        {
            transform.position = new Vector2(transform.position.x, -transform.position.y - 1);
        }
        else if (_position.y > Screen.height + 40)
        {
            transform.position = new Vector2(transform.position.x, -transform.position.y + 1);
        }
    }
}