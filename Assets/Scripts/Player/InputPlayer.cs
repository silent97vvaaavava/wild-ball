using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Оброботчик ввода игрока
/// </summary>
public class InputPlayer : MonoBehaviour
{
    [SerializeField] MovmentObject movmentObject;
    float dirX;

    public MovmentObject MovmentObject { get => movmentObject; set => movmentObject = value; }

    private void Awake()
    {
        movmentObject.Rb = GetComponent<Rigidbody>();  
    }

    private void Update()
    {
        dirX = -Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        movmentObject.Rb.velocity = new Vector3(movmentObject.SpeedForward + movmentObject.Sprint, movmentObject.Rb.velocity.y, movmentObject.Rb.velocity.z);
        movmentObject.Moving(dirX);
    }

    public void StartCor()
    {
        StartCoroutine(DecreaseSprint());
    }

    public IEnumerator DecreaseSprint()
    {
        movmentObject.Sprint = 5;
        while (movmentObject.Sprint >= 0)
        {
            movmentObject.Sprint -= .01f;
            yield return null;
        }
        movmentObject.Sprint = 0;
    }
}
