using UnityEngine;

public class AccelarationPlane : MonoBehaviour
{
    [SerializeField] private float _accelaration;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<IAccelaration>(out var accelaration))
        {
            accelaration.Accelaration(_accelaration);
        }
    }
}
