using UnityEngine;
using Zenject;

public class GroundInstaller : MonoInstaller
{
    [SerializeField] private ObjectsPool pool;
    [SerializeField] private SpawnGround spawn;

    public override void InstallBindings()
    {
        Container.Bind<ObjectsPool>().FromInstance(pool).AsSingle().NonLazy();
        Container.Bind<SpawnGround>().FromInstance(spawn).AsSingle().NonLazy();
    }
}