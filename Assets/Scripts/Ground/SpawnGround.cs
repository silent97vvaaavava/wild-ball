using UnityEngine;
using Zenject;

public class SpawnGround : MonoBehaviour
{
    [SerializeField] private ObjectsPool _pool;

    private GameObject _ground;
    private Vector3 _nextPosition;

    private void Start()
    {
        var temp = _pool.GetObject();
        temp.SetActive(true);
        _nextPosition = temp.GetComponent<Ground>().NextPosition;
        for (int i = 0; i < 4; i++)
        {
            SetGround();
        }
    }

    public void SetGround()
    {
        _ground = _pool.GetObject();
        _ground.transform.position = _nextPosition;
        _ground.SetActive(true);
        _nextPosition = _ground.GetComponent<Ground>().NextPosition;
    }
}
