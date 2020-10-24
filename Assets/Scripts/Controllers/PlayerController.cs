using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private MovementBase movementBehaviour;
    private ShootingBase shootingBehaviour;

    private void Awake()
    {
        movementBehaviour = GetComponent<MovementBase>();
        shootingBehaviour = GetComponent<ShootingBase>();
    }

    private void Update()
    {
        HandleMovement();
        HandleShooting();
    }

    private void HandleMovement()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        if (horizontal != 0 || vertical != 0)
        {
            movementBehaviour.Move(horizontal, vertical);
        }
    }

    private void HandleShooting()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            shootingBehaviour.Shoot();
        }
    }
}