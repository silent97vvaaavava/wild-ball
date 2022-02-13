using UnityEngine;

public class CollisionGround : MonoBehaviour
{
    [SerializeField] private Ground _ground;

    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent<PlayerUnit>(out var playerUnit))
        {
            _ground.DisableGround();
        }
    }
}
