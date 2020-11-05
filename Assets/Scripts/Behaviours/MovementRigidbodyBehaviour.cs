using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MovementRigidbodyBehaviour : MovementBase
{
    private Rigidbody myRigidbody;

    private void Awake()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    public override void Move(float moveX, float moveY, float moveZ)
    {
        Vector3 direction = new Vector3(moveX, moveY, moveZ);
        myRigidbody.MovePosition(transform.position + direction.normalized * speedData.Speed * Time.fixedDeltaTime);
    }
}