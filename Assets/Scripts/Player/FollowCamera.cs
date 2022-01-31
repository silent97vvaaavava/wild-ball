using UnityEngine;

/// <summary>
/// Следеование камеры за игроком
/// </summary>
[RequireComponent(typeof(Camera))]
public class FollowCamera : MonoBehaviour
{
    [SerializeField] Transform playerPosition;
    [SerializeField] Vector3 deltaDistance;

    private void Awake()
    {
        transform.position = playerPosition.position + deltaDistance;
    }

    private void LateUpdate()
    {
        if(playerPosition)
        transform.position = playerPosition.position + deltaDistance;
    }
}
