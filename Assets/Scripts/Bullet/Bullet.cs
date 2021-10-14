using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed;

    void FixedUpdate()
    {
        transform.Translate(Vector2.right * _speed);
    }
}