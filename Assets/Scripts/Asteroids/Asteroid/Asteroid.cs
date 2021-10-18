using UnityEngine;

public class Asteroid : AsteridMovement
{
    public int CountMiniAsteroids;
    private DisableAsteroids _disableAsteroids;
    private MiniAsteroidsStorage _miniAsteroidsStorage;

    private void Start()
    {
        _miniAsteroidsStorage = FindObjectOfType<MiniAsteroidsStorage>();
        _disableAsteroids = FindObjectOfType<DisableAsteroids>();
    }

    private void OnEnable()
    {
        CountMiniAsteroids = 2;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _miniAsteroidsStorage.StartMiniAsteroids(this, transform.position);
        _disableAsteroids.Disable(gameObject);
    }
}