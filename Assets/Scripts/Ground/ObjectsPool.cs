using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class ObjectsPool : MonoBehaviour
{
    [SerializeField] GameObject[] prefabs; //массива префабов для создания очереди из объектов
    [Inject] private DiContainer diContainer;


    [SerializeField] int count; // количество объектов пула
    public Queue<GameObject> Objects = new Queue<GameObject>();

    private void Awake()
    {
        System.Random random = new System.Random();
        InitPool(random);
    }

    /// <summary>
    /// Создание пула при включении игры
    /// </summary>
    /// <param name="random"></param>
    void InitPool(System.Random random)
    {
        for (int i = 0; i < count; i++)
        {
            var tempGO = diContainer.InstantiatePrefab(prefabs[random.Next(0, prefabs.Length)],
                transform);
            //var tempGO = Instantiate(prefabs[random.Next(0, prefabs.Length)], transform, false);
            tempGO.SetActive(false);
            Objects.Enqueue(tempGO);
        }
    }

    /// <summary>
    /// Получение объекта из очереди
    /// </summary>
    /// <returns>объект</returns>
    public GameObject GetObject()
    {
        var obj = Objects.Dequeue();
        //obj.SetActive(true);
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

}
