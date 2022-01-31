using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class ResultScore : MonoBehaviour
{
    [SerializeField] Text result;
    [Inject] ScoreData score;

    public void ShowResult()
    {
        this.gameObject.SetActive(true);
        result.text = score.Score.ToString();
    }
}
