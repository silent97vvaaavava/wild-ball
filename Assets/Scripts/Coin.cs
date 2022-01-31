using UnityEngine;
using Zenject;

public class Coin : MonoBehaviour
{
    [Inject] ScoreData _score;

    Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animator.SetTrigger("Destroy");
        }
    }

    void DestroyObj()
    {
        gameObject.SetActive(false);
        _score.UpdateScore();
    }
}
