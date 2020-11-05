using UnityEngine;

public abstract class MovementBase : MonoBehaviour
{
    [SerializeField] protected SpeedData speedData;

    public void Move(float moveX, float moveY)
    {
        Move(moveX, moveY, 0);
    }

    public abstract void Move(float moveX, float moveY, float moveZ);
}