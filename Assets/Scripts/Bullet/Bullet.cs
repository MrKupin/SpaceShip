using System.Collections;
using UnityEngine;

public class Bullet : BaseTeleport
{
    [SerializeField] private float _speed;

    void FixedUpdate()
    {
        transform.Translate(Vector2.right * _speed);
        StartCoroutine(Disable());
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameObject.SetActive(false);
    }

    IEnumerator Disable()
    {
        yield return new WaitForSeconds(0.2f);
        gameObject.SetActive(false);
    }
}