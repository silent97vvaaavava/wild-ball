using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    [SerializeField] Transform nextPoint;
    public Vector3 nextPosition { get => nextPoint.position; }

    private void OnBecameInvisible()
    {
        SpawnGround._instantion.SetGround();
        ObjectsPool._instantion.DestroyObject(this.gameObject);
    }
}
