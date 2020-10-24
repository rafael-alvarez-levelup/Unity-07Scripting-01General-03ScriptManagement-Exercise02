using UnityEngine;

[CreateAssetMenu(fileName = "ProjectileData", menuName = "Data/Projectile")]
public class ProjectileData : ScriptableObject
{
    public Rigidbody Projectile
    {
        get
        {
            return projectile;
        }
        private set
        {
            projectile = value;
        }
    }
    public float ProjectileForce
    {
        get
        {
            return projectileForce;
        }
        private set
        {
            projectileForce = value;
        }
    }

    [SerializeField] private Rigidbody projectile;
    [SerializeField] private float projectileForce;
}