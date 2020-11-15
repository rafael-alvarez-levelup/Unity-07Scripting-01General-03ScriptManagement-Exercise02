using UnityEngine;

[CreateAssetMenu(fileName = "SpeedData", menuName = "Data/Speed")]
public class SpeedData : ScriptableObject
{
    public float Speed
    {
        get
        {
            return speed;
        }
    }

    [SerializeField] private float speed;
}