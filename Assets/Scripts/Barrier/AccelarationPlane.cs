using UnityEngine;

public class AccelarationPlane : MonoBehaviour
{
    [SerializeField] float accelaration;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<IAccelaration>().Accelaration(accelaration);
        }
    }
}
