using UnityEngine;

public class CheckForAsteroids : MonoBehaviour
{
    [SerializeField] public AsteroidsStorage _asteroidsStorage;
    [SerializeField] private WaveController _waveOfAttack;

    public void CheckAscteroids()
    {
        int count = 0;
        foreach (Asteroid asteroid in _asteroidsStorage.Asteriods)
        {
            if (asteroid.CountMiniAsteroids > 0)
            {
                count++;
            }
        }
        if (count == 0)
        {
            _waveOfAttack.NewWave();
        }
    }
}