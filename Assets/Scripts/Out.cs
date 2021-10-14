using UnityEngine;

public class Out : MonoBehaviour
{
    [SerializeField] GameObject _theEnd;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.GetComponent<Out>())
        {
            Destroy(collision.gameObject);
            _theEnd.SetActive(true);
        }
    }
}