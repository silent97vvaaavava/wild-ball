using UnityEngine;

[System.Serializable]
public class MovementUnit : IMoveAccelaration
{
    Rigidbody _rigidbody;

    public MovementUnit(Rigidbody rigidbody)
    {
        this._rigidbody = rigidbody;
    }

    public void Accelaration(float accel)
    {
        _rigidbody.AddForce(Vector3.right * accel, ForceMode.Impulse);
    }

    public void Movement(Vector3 vectorMove)
    {
        _rigidbody.AddForce(vectorMove + _rigidbody.velocity, ForceMode.Force);
    }
}

public interface IMoveAccelaration 
{
    void Accelaration(float accel);
}
