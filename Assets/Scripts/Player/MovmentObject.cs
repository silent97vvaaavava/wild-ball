using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MovmentObject : MonoBehaviour
{
    [SerializeField] private float speedForward;
    [SerializeField] private float speedHorizontal;

    Rigidbody rb;

    public float SpeedForward { get => speedForward; set => speedForward = value; }

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        InputPlayer._instantion.Moving += Moving;
    }

    void Moving(float direction)
    {
        rb.AddForce(Vector3.back * direction * speedHorizontal, ForceMode.Impulse);
    }


    private void FixedUpdate()
    {
        rb.AddForce(Vector3.right * Time.deltaTime * speedForward, ForceMode.Impulse);
    }

    private void OnDestroy()
    {
        InputPlayer._instantion.Moving -= Moving;
    }

}
