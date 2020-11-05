using UnityEngine;

public class MovementTransformBehaviour : MovementBase
{
    public override void Move(float moveX, float moveY, float moveZ)
    {
        Vector3 direction = new Vector3(moveX, moveY, moveZ);
        transform.Translate(direction * speedData.Speed * Time.deltaTime);
    }
}