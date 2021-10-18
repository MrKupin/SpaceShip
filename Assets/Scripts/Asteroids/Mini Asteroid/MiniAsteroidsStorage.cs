using System.Collections.Generic;
using UnityEngine;

public class MiniAsteroidsStorage : MonoBehaviour
{
    [SerializeField] private MiniAsteroid _miniAsteroidPrefab;
    [SerializeField] private List<MiniAsteroid> _miniAsteroids;

    private void Start()
    {
        for (int i = 0; i < 6; i++)
        {
            _miniAsteroids.Add(Instantiate(_miniAsteroidPrefab, transform));
        }
    }

    public void StartMiniAsteroids(Asteroid asteroid, Vector2 position)
    {
        int number = 0;
        foreach (MiniAsteroid miniAsteroid in _miniAsteroids)
        {
            if (number < 2)
            {
                if (!miniAsteroid.gameObject.activeInHierarchy)
                {
                    number++;
                    miniAsteroid.transform.position = position;
                    miniAsteroid.SetAsteroid(asteroid);
                    miniAsteroid.gameObject.SetActive(true);
                }
            }
            else
            {
                break;
            }
        }
    }
}