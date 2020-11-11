using UnityEngine;

public class ShootingProjectileBehaviour : ShootingBase
{
    [SerializeField] private ProjectileData projectileData;

    public override void Shoot(Vector3 direction)
    {
        Rigidbody projectile = Instantiate(projectileData.Projectile, transform.position, Quaternion.identity);

        projectile.AddForce(direction * projectileData.ProjectileForce);
    }
}