using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class ScoreData : MonoBehaviour
{
    [SerializeField] private Text _textScore;
    [SerializeField] private Firework _firework;
    private int _score;
    private IAddPlatform _addPlatform;
    private PlayerUnit _playerUnit;
    private ShowLevel _showLevel;
    public int Score => _score; 

    [Inject]
    public void Construct(IAddPlatform addPlatform, PlayerUnit playerUnit, ShowLevel showLevel)
    {
        _addPlatform = addPlatform;
        _playerUnit = playerUnit;
        _showLevel = showLevel;
    }

    public void UpdateScoreText()
    {
        gameObject.SetActive(true);
        UpdateScore();
        _textScore.text = _score.ToString();
    }

    private void UpdateScore()
    {
        _score++;
        var level = _score / 10;
        var check = _score % 10;
        if(check == 0 && _score > 0)
        {
            _addPlatform.AddPlatform(level);
            var distanceFirework = _playerUnit.transform.position + new Vector3(10f, 1f, 0);
            _firework.transform.position = distanceFirework;
            _firework.StartFirework();
            _showLevel.Show(level);
        }
    }
}
