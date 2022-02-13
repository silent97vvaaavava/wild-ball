using UnityEngine;

public class BarrierCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<PlayerUnit>(out var unit))
        {
            unit.Death();
        }
    }
}
