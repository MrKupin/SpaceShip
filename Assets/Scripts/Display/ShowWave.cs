using UnityEngine;
using UnityEngine.UI;

public class ShowWave : MonoBehaviour
{
    [SerializeField] private Text _showWave;

    public void Display(int nowWave, int maxWave)
    {
        _showWave.text = nowWave.ToString() + "/" + maxWave.ToString();
    }
}