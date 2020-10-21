using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float _speed = 5;

    [SerializeField]
    private Rigidbody _projectil;

    [SerializeField]
    private float _projectileForce = 20;

    private void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        var direction = new Vector3(horizontal, vertical, 0);
        transform.Translate(direction * _speed * Time.deltaTime);

        if (Input.GetButtonDown("Fire1"))
        {
            var projectile = Instantiate(_projectil, transform.position, Quaternion.identity);
            var mouseInput = Input.mousePosition;
            mouseInput.z = 10;
            var mousePosition = Camera.main.ScreenToWorldPoint(mouseInput);
            mousePosition.z = 0;
            var projectileDelta = mousePosition - transform.position;
            projectile.AddForce(projectileDelta.normalized * _projectileForce);
        }
    }

}
