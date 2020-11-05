using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region Private Variables

    private MovementBase movementBehaviour;
    private ShootingBase shootingBehaviour;

    #endregion

    #region Unity Methods

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

    #endregion

    #region My Methods

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

    #endregion
}