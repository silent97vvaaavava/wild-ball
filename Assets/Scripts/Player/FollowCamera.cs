using UnityEngine;
using Zenject;

/// <summary>
/// Следеование камеры за игроком
/// </summary>
public class FollowCamera : MonoBehaviour
{
    [SerializeField] private Vector3 _deltaDistance;
    private PlayerUnit _playerUnit;

    [Inject]
    public void Construct(PlayerUnit playerUnit)
    {
        _playerUnit = playerUnit;
    }

    private void Awake()
    {
        transform.position = _playerUnit.transform.position + _deltaDistance;
    }

    private void LateUpdate()
    {
        if(_playerUnit)
        transform.position = _playerUnit.transform.position + _deltaDistance;
    }
}
