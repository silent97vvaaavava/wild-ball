using UnityEngine;
using Zenject;

public class ScoreInstaller : MonoInstaller
{
    [SerializeField] private ScoreData _score;
    [SerializeField] private ShowLevel _showLevel;

    public override void InstallBindings()
    {
        Container.Bind<ScoreData>().FromInstance(_score).AsSingle().NonLazy();
        Container.Bind<ShowLevel>().FromInstance(_showLevel).AsSingle().NonLazy();
    }
}