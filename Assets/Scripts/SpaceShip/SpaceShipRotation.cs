using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipRotation : MonoBehaviour
{
    private Vector3 _cursorPosition;
    Vector2 _target;
    Vector2 _rotate;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            _cursorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            _target = _cursorPosition - transform.position;
            _rotate = _rotate.normalized;
            _rotate = Vector2.MoveTowards(_rotate, _target, 0.06f);
            transform.right = _rotate;
        }
    }
}