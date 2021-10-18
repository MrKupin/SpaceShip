using UnityEngine;

public class Death : MonoBehaviour
{
    [SerializeField] private Animator _deathAnimator;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.GetComponent<Bullet>())
        {
            _deathAnimator.SetTrigger("Death");
        }
    }
}