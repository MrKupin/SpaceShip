using UnityEngine;

public class WaveController : MonoBehaviour
{
    [SerializeField] private PlaceAsteroids _placeAsteroids;
    [SerializeField] private ShowWave _showWave;
    [SerializeField] private Animator _waveAnimator;
    [SerializeField] private Animator _victory;
    private int _nowWave = 1;
    private int _maxWave = 3;

    private void Start()
    {
        StartWave();
    }

    public void StartWave()
    {
        _placeAsteroids.Place(_nowWave);
        _showWave.Display(_nowWave, _maxWave);
    }

    public void NewWave()
    {
        if (_nowWave < _maxWave)
        {
            _nowWave += 1;
            _waveAnimator.SetTrigger("NewWave");
        }
        else
        {
            _victory.SetTrigger("Victory");
        }
    }
}