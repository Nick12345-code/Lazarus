using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] private Collectable collectable;
    private Health health;

    private void Start() => health = GetComponent<Health>();

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Collectable"))
        {
            collectable.Gain(1);
            Destroy(collision.collider.gameObject);
        }

        if (collision.collider.CompareTag("Obstacle"))
        {
            health.LoseLife(1);
            Destroy(collision.collider.gameObject);
        }
    }
}
