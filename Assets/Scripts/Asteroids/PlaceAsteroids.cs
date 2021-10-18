using UnityEngine;

public class PlaceAsteroids : MonoBehaviour
{
    [SerializeField] private AsteroidsStorage _asteroidsStorage;
    private Vector2 _cameraBoundaries;

    private void Awake()
    {
        _cameraBoundaries = Camera.main.ViewportToWorldPoint(_cameraBoundaries);
    }

    public void Place(int number)
    {
        for (int i = 0; i < number; i++)
        {
            Asteroid asteroid = _asteroidsStorage.GetAsteroid();
            asteroid.transform.position = new Vector2(Random.Range(-_cameraBoundaries.x, _cameraBoundaries.x), Random.Range(-_cameraBoundaries.y, _cameraBoundaries.y));
            asteroid.gameObject.SetActive(true);
        }
    }
}