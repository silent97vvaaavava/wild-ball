using UnityEngine;
using Zenject;

public class GroundInstaller : MonoInstaller
{
    [SerializeField] private ObjectsPool _pool;
    [SerializeField] private SpawnGround _spawn;

    public override void InstallBindings()
    {
        Container.Bind<IAddPlatform>().FromInstance(_pool);
        Container.Bind<ObjectsPool>().FromInstance(_pool).AsSingle().NonLazy();
        Container.Bind<SpawnGround>().FromInstance(_spawn).AsSingle().NonLazy();
    }
}