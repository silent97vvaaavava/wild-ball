using UnityEngine;
using Zenject;

public class ScoreInstaller : MonoInstaller
{
    [SerializeField] private ScoreData score;
    [SerializeField] private ResultScore result;


    public override void InstallBindings()
    {
        Container.Bind<ScoreData>().FromInstance(score).AsSingle().NonLazy();
        Container.Bind<ResultScore>().FromInstance(result).AsSingle().NonLazy();
    }
}