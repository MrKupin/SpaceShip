using System.Collections;
using UnityEngine;

public class MiniAsteroid : AsteridMovement
{
    private CheckForAsteroids _checkForAsteroids;
    private Asteroid _asteroid;
    private bool _isReady;

    private void Start()
    {
        _checkForAsteroids = FindObjectOfType<CheckForAsteroids>();
    }

    private void OnEnable()
    {
        _isReady = false;
        StartCoroutine(Active());
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }

    public void SetAsteroid(Asteroid asteroid)
    {
        _asteroid = asteroid;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (_isReady)
        {
            _asteroid.CountMiniAsteroids -= 1;
            _checkForAsteroids.CheckAscteroids();
            gameObject.SetActive(false);
        }
    }

    IEnumerator Active()
    {
        yield return new WaitForSeconds(0.5f);
        _isReady = true;
    }
}