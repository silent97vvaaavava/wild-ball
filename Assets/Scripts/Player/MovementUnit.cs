using UnityEngine;

[System.Serializable]
public class MovementUnit : IMoveAccelaration
{
    Rigidbody rb;

    public MovementUnit(Rigidbody rb)
    {
        this.rb = rb;
    }

    public void Accelaration(float accel)
    {
        //rb.AddRelativeForce(Vector3.right * accel, ForceMode.Impulse);
        rb.AddForce(Vector3.right * accel, ForceMode.Impulse);
    }

    public void Movement(Vector3 vectorMove)
    {
        rb.AddForce(vectorMove + rb.velocity, ForceMode.Force);
    }
}

public interface IMoveAccelaration 
{
    void Accelaration(float accel);
}
