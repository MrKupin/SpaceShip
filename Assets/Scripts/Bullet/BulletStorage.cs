using System.Collections.Generic;
using UnityEngine;

public class BulletStorage : MonoBehaviour
{
    [SerializeField] private Bullet _bulletPrefab;
    [SerializeField] private List<Bullet> _bullets;
    private int _bulletCount = 10;

    private void Start()
    {
        for (int i = 0; i < _bulletCount; i++)
        {
            _bullets.Add(Instantiate(_bulletPrefab, transform));
        }
    }

    public GameObject GetBullet()
    {
        foreach (Bullet bullet in _bullets)
        {
            if (!bullet.gameObject.activeInHierarchy)
                return bullet.gameObject;
        }
        return null;
    }
}