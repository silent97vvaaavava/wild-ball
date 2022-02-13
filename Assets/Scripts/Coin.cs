using UnityEngine;
using Zenject;

public class Coin : MonoBehaviour
{
    [Inject] private ScoreData _score;

    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<PlayerUnit>(out var player))
        {
            _animator.SetTrigger("Destroy");
        }
    }

    void DestroyObj()
    {
        gameObject.SetActive(false);
        _score.UpdateScoreText();
    }
}
