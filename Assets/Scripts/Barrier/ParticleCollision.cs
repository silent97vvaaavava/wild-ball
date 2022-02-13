using UnityEngine;

public class ParticleCollision : MonoBehaviour
{
    private void OnParticleCollision(GameObject other)
    {
        if (other.TryGetComponent<PlayerUnit>(out var unit))
        {
            unit.Death();
        }
    }
}
