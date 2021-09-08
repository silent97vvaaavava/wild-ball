using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MovmentObject 
{
    [SerializeField] private float speedForward;
    [SerializeField] private float speedHorizontal;
    [SerializeField] private float sprint;

    private Rigidbody rb;

    public float SpeedForward { get => speedForward; set => speedForward = value; }
    public float SpeedHorizontal { get => speedHorizontal; set => speedHorizontal = value; }
    public Rigidbody Rb { get => rb; set => rb = value; }
    public float Sprint { get => sprint;  set => sprint = value; }

    public MovmentObject(float speedForward, float speedHorizontal, Rigidbody rb)
    {
        this.speedForward = speedForward;
        this.speedHorizontal = speedHorizontal;
        this.rb = rb;
    }

    public void Moving(float direction)
    {
        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, speedHorizontal * direction); // написать интерполяцию для поворотов: медленно стартует и затухает (плавные смещения) 
    }

    public IEnumerator DecreaseSprint()
    {
        sprint = 5;
        while (sprint > 0)
        {
            sprint -= .01f;
            yield return null;
        }
        sprint = 0;
    }
}
