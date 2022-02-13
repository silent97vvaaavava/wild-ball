using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class ObjectsPool : MonoBehaviour, IAddPlatform
{
    public Queue<GameObject> Objects = new Queue<GameObject>();

    [SerializeField] private GameObject[] _prefabs; //массива префабов для создания очереди из объектов
    [SerializeField] private GameObject[] _addPref;
    [SerializeField] private int _count; // количество объектов пула

    [Inject] private DiContainer _diContainer;

    private void Awake()
    {
        System.Random random = new System.Random();
        InitPool(random);
    }

    public void AddPlatform(int index)
    {
        _count++;
        var tempIndex = index % _addPref.Length;
        Objects.Enqueue(AddToPool(_addPref[tempIndex]));
    }

    /// <summary>
    /// Получение объекта из очереди
    /// </summary>
    /// <returns>объект</returns>
    public GameObject GetObject()
    {
        var obj = Objects.Dequeue();
        return obj;
    }

    /// <summary>
    /// Возвращение объекта в пул и сбрасывает настройки
    /// </summary>
    /// <param name="ob"></param>
    public void DestroyObject(GameObject ob)
    {
        Objects.Enqueue(ob);
        ob.SetActive(false);
    }

    /// <summary>
    /// Создание пула при включении игры
    /// </summary>
    /// <param name="random"></param>
    private void InitPool(System.Random random)
    {
        for (int i = 0; i < _count; i++)
        {
            var tempGO = _diContainer.InstantiatePrefab(_prefabs[random.Next(0, _prefabs.Length)],
                transform);
            tempGO.SetActive(false);
            Objects.Enqueue(tempGO);
        }
    }

    private GameObject AddToPool(GameObject prefab)
    {
        var tempGO = _diContainer.InstantiatePrefab(prefab, transform);
        tempGO.SetActive(false);
        return tempGO;
    }
    
}
