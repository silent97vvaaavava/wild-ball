using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Оброботчик ввода игрока
/// </summary>
public class InputPlayer : MonoBehaviour
{
    public static InputPlayer _instantion;
    public event Action<float> Moving = delegate { };

    private void Awake()
    {
        if (!_instantion)
        {
            _instantion = this;
        }
    }


    void Update()
    {
        Moving(Input.GetAxis("Horizontal"));
    }
}
