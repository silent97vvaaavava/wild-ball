using UnityEngine;

public class Firework : MonoBehaviour
{
    [SerializeField] private GameObject[] _firework;

    public void StartFirework()
    {
        foreach (var item in _firework)
        {
            item.SetActive(true);
            
        }
    }
}
