using UnityEngine;

public class NewWave : MonoBehaviour
{
    [SerializeField] private WaveController _waveOfAttack;

    public void StartNewWave()
    {
        _waveOfAttack.StartWave();
    }
}