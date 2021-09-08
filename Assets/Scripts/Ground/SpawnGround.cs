using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGround : MonoBehaviour
{
    public static SpawnGround _instantion;

    GameObject ground;
    Vector3 nextPosition;

    private void Awake()
    {
        if (!_instantion)
        {
            _instantion = this;
        }
    }

    private void Start()
    {
        var temp = ObjectsPool._instantion.GetObject();
        temp.SetActive(true);
        nextPosition = temp.GetComponent<Ground>().nextPosition;
        for (int i = 0; i < 4; i++)
        {
            SetGround();
        }
    }

    public void SetGround()
    {
        ground = ObjectsPool._instantion.GetObject();
        ground.transform.position = nextPosition;
        ground.SetActive(true);
        nextPosition = ground.GetComponent<Ground>().nextPosition;
    }
}
