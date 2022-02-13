using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class ResultScore : MonoBehaviour
{
    [SerializeField] private Text _result;
    private ScoreData _score;
    private PlayerUnit _playerUnit;

    [Inject]
    public void Construct(PlayerUnit playerUnit, ScoreData score)
    {
        _playerUnit = playerUnit;
        _playerUnit.ShowResult = ShowResult;
        _score = score;
    }

    public void ShowResult()
    {
        gameObject.SetActive(true);
        _result.text = _score.Score.ToString();
    }
}
