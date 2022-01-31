using UnityEngine;

public class BarrierCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerUnit>().Death();
        }
    }
}
