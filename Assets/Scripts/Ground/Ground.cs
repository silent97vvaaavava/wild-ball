using UnityEngine;
using Zenject;

public class Ground : MonoBehaviour
{
    [SerializeField] private Transform _nextPoint;
    [SerializeField] private GameObject[] _coins;
    private SpawnGround _spawn;
    private ObjectsPool _pool;

    public Vector3 NextPosition => _nextPoint.position;

    [Inject]
    public void Constract(SpawnGround spawn, ObjectsPool pool)
    {
        _spawn = spawn;
        _pool = pool;
    }

    public void DisableGround()
    {

        ShowCoins();
        _pool.DestroyObject(gameObject);
        _spawn.SetGround();
    }

    private void ShowCoins()
    {
        for (int i = 0; i < _coins.Length; i++)
        {
            if (_coins[i].activeSelf) continue;
            _coins[i].SetActive(true);
        }
    }
}
