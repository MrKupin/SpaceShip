using UnityEngine;

public class SpaceShipMoving : BaseTeleport
{
    private float _speed;
    public float Speed
    {
        get
        {
            if (_speed > 1) _speed = 0.5f;
            if (_speed < 0) _speed = 0;
            return _speed;
        }
        set
        {
            _speed = value;
        }
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Speed += 0.0009f;
        }
        Speed -= 0.0004f;
        transform.Translate(Vector2.right * Speed);
    }
}