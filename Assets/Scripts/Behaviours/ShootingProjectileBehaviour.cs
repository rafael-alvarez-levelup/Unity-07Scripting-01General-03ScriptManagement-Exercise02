using UnityEngine;

public class ShootingProjectileBehaviour : ShootingBase
{
    [SerializeField] private ProjectileData projectileData;

    public override void Shoot()
    {
        Rigidbody projectile = Instantiate(projectileData.Projectile, transform.position, Quaternion.identity);

        Vector3 projectileDelta = MouseManager.Instance.GetMouseWorldPosition() - transform.position;
        projectile.AddForce(projectileDelta.normalized * projectileData.ProjectileForce);
    }
}