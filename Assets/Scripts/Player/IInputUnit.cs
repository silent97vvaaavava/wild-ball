using UnityEngine;

public interface IInputUnit
{
    Vector3 GetDirection(float speed, float speedForward);
}