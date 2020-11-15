using UnityEngine;

[CreateAssetMenu(fileName = "ProjectileData", menuName = "Data/Projectile")]
public class ProjectileData : ScriptableObject
{
    #region Properties

    public Rigidbody Projectile
    {
        get
        {
            return projectile;
        }
    }
    public float ProjectileForce
    {
        get
        {
            return projectileForce;
        }
    }

    #endregion

    #region Private Variables

    [SerializeField] private Rigidbody projectile;
    [SerializeField] private float projectileForce;

    #endregion
}