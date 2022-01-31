using UnityEngine;
using Zenject;

public class SpawnGround : MonoBehaviour
{
    [SerializeField] private ObjectsPool _pool;

    GameObject ground;
    Vector3 nextPosition;

    private void Start()
    {
        var temp = _pool.GetObject();
        temp.SetActive(true);
        nextPosition = temp.GetComponent<Ground>().nextPosition;
        for (int i = 0; i < 4; i++)
        {
            SetGround();
        }
    }

    public void SetGround()
    {
        ground = _pool.GetObject();
        ground.transform.position = nextPosition;
        ground.SetActive(true);
        nextPosition = ground.GetComponent<Ground>().nextPosition;
    }
}
