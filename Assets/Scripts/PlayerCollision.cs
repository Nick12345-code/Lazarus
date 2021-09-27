using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] private Collectable collectable;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Collectable"))
        {
            collectable.Gain(1);
            Destroy(collision.collider.gameObject);
        }
    }
}
