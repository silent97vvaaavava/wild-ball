using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Ground : MonoBehaviour
{
    [SerializeField] Transform nextPoint;
    [SerializeField] GameObject[] coins;
    public Vector3 nextPosition { get => nextPoint.position; }

    System.Random random = new System.Random();

    [Inject] private SpawnGround _spawn;
    [Inject] private ObjectsPool _pool;

    private void OnBecameInvisible()
    {
        ShowCoins();
        _pool.DestroyObject(this.gameObject);
        _spawn.SetGround();
    }

    void ShowCoins()
    {
        for (int i = 0; i < coins.Length; i++)
        {
            if (coins[i].activeSelf) continue;
            coins[i].SetActive(true);
        }
    }
}
