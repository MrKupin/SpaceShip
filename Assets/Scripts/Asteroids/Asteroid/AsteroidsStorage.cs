using System.Collections.Generic;
using UnityEngine;

public class AsteroidsStorage : MonoBehaviour
{
    [SerializeField] private List<Asteroid> _asteriods;
    public List<Asteroid> Asteriods => _asteriods;
    [SerializeField] private Asteroid _asteroidPrefab;

    void Awake()
    {
        for (int i = 0; i < 3; i++)
        {
            _asteriods.Add(Instantiate(_asteroidPrefab, transform));
        }
    }

    public Asteroid GetAsteroid()
    {
        foreach (Asteroid asteroid in _asteriods)
        {
            if (asteroid.CountMiniAsteroids == 0)
            {
                return asteroid;
            }
        }
        return null;
    }
}