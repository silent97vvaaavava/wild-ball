using System;
using UnityEngine;
using Zenject;

public class PlayerUnit : MonoBehaviour, IAccelaration
{
    public Action ShowResult; 
    [SerializeField] private ParticleSystem _particle;
    [SerializeField] private float _speed;
    [SerializeField] private float _speedForward;

    private ResultScore _result;
    
    private MovementUnit _movement;
    private IInputUnit _inputUnit = new InputPlayer();
    private Vector3 _direction;


    private void Awake()
    {
        _movement = new MovementUnit(GetComponent<Rigidbody>());
    }

    private void Update()
    {
        _direction = _inputUnit.GetDirection(_speed, _speedForward);
    }

    private void FixedUpdate()
    {
        _movement.Movement(_direction);
    }

    public void Accelaration(float speed)
    {
        _movement.Accelaration(speed);
        if (speed < 0 && Mathf.Abs(speed) + 2.5f > _speedForward)
            return;
        else
        if (_speedForward < 20 || speed < 0)
            _speedForward += speed;
    }

    public void Death()
    {
        ShowResult?.Invoke();
        Instantiate(_particle, transform.position, Quaternion.identity);
        gameObject.SetActive(false);
    }
}

public interface IAccelaration
{
    void Accelaration(float speed);
}