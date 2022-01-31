using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreData : MonoBehaviour
{
    [SerializeField] private Text textScore;
    int score;

    public int Score { get => score; }

    public void UpdateScore()
    {
        gameObject.SetActive(true);
        score++;
        textScore.text = score.ToString();
    }
}
