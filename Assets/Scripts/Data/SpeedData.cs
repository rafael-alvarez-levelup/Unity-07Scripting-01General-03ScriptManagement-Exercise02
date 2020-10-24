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
        private set
        {
            speed = value;
        }
    }

    [SerializeField] private float speed;
}