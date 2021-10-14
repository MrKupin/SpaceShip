using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowRecharge : MonoBehaviour
{
    private Image _showRecharge;

    void Start()
    {
        _showRecharge = GetComponent<Image>();
    }

    public void Show(float fillAmount)
    {
        _showRecharge.fillAmount = fillAmount;
    }
}