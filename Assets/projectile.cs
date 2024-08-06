using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;
    [SerializeField] private float _lifetime = 5f;

    private Vector2 _direction;

    private void Start()
    {
        // Destroy the projectile after a certain time
        Destroy(gameObject, _lifetime);
    }

    public void Initialize(Vector2 direction)
    {
        _direction = direction;
    }

    private void Update()
    {
        // Move the projectile in the direction
        transform.Translate(_direction * _speed * Time.deltaTime);
    }
}
