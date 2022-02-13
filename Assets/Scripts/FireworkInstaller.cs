using UnityEngine;
using Zenject;

public class FireworkInstaller : MonoInstaller
{
    [SerializeField] private Firework _firework;
    [SerializeField] private Transform _positionPlayer;

    public override void InstallBindings()
    {
        Debug.Log("Instance");
    }
}