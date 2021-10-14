using System.Collections;
using UnityEngine;

public class Shot : MonoBehaviour
{
    [SerializeField] private BulletStorage _bulletStorage;
    [HideInInspector] public float _isRecharge = 1f;
    private float _rechargeTime = 1f;
    private float _shootingSpeed = 0.4f;
    private int _numberOfShotsFired = 3;
    [SerializeField] private ShowRecharge _showRecharge;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _isRecharge >= 1f)
        {
            _isRecharge = 0;
            StartCoroutine(Shooting());
            StartCoroutine(Recharge());
        }
    }

    IEnumerator Recharge()
    {
        for (int i = 0; i < 10; i++)
        {
            _isRecharge += 0.1f;
            _showRecharge.Show(_isRecharge);
            yield return new WaitForSeconds(_rechargeTime);
        }
    }

    IEnumerator Shooting()
    {
        for (int i = 0; i < _numberOfShotsFired; i++)
        {
            var bullet = _bulletStorage.GetBullet();
            if (bullet)
            {
                bullet.gameObject.SetActive(true);
                bullet.transform.position = transform.position;
                bullet.transform.rotation = transform.rotation;
                yield return new WaitForSeconds(_shootingSpeed);
            }
        }
    }
}