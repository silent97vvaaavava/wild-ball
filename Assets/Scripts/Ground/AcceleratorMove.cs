using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Толкает игрока с большей скоростью чем его исходная
/// </summary>
public class AcceleratorMove : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("Work trigger");
            other.GetComponent<InputPlayer>().StartCor();
            
        }
    }

   
}
