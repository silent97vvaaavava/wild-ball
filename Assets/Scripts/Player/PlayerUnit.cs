using UnityEngine;
using Zenject;

public class PlayerUnit : MonoBehaviour, IAccelaration
{
    [SerializeField] ParticleSystem particle;
    [SerializeField] float speed;
    [SerializeField] float speedForward;

    [Inject] private ResultScore result;


    MovementUnit movement;
    IInputUnit inputUnit = new InputPlayer();

    Vector3 direction;

    public void Accelaration(float speed)
    {
        movement.Accelaration(speed);
        if (speed < 0 && Mathf.Abs(speed) + 2.5f > speedForward)
            return;
        else 
        if(speedForward < 20 || speed < 0)
            speedForward += speed;
    }

    private void Awake()
    {
        movement = new MovementUnit(GetComponent<Rigidbody>());
    }

    private void Update()
    {
        direction = inputUnit.GetDirection(speed, speedForward);
    }

    private void FixedUpdate()
    {
        movement.Movement(direction);
    }

    public void Death()
    {
        Instantiate(particle, transform.position, Quaternion.identity);
        gameObject.SetActive(false);
        result.ShowResult();
    }
}

public interface IAccelaration
{
    void Accelaration(float speed);
}