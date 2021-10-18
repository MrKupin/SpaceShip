using System.Collections;
using UnityEngine;

public class Shot : MonoBehaviour
{
    [SerializeField] private BulletStorage _bulletStorage;
    [HideInInspector] public float _isRecharge = 1f;
    private float _rechargeStep = 0.1f;
    [SerializeField] private ShowRecharge _showRecharge;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _isRecharge >= 1f)
        {
            _isRecharge = 0;
            Shooting();
            StartCoroutine(Recharge());
        }
    }

    IEnumerator Recharge()
    {
        for (int i = 0; i < 10; i++)
        {
            _isRecharge += 0.1f;
            _showRecharge.Show(_isRecharge);
            yield return new WaitForSeconds(_rechargeStep);
        }
    }

    private void Shooting()
    {
        var bullet = _bulletStorage.GetBullet();
        if (bullet)
        {
            bullet.gameObject.SetActive(true);
            bullet.transform.position = transform.position;
            bullet.transform.rotation = transform.rotation;
        }
    }
}