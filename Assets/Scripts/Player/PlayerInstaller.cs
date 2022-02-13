using UnityEngine;
using Zenject;

public class PlayerInstaller : MonoInstaller
{
    [SerializeField] private PlayerUnit _playerUnit;

    public override void InstallBindings()
    {
        var playerInstaller = Container.InstantiatePrefabForComponent<PlayerUnit>(_playerUnit, Vector3.right, Quaternion.identity, null);
        Container.Bind<PlayerUnit>().FromInstance(playerInstaller).AsSingle().NonLazy();
    }
}