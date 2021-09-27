using UnityEngine;

public class Destroyer : MonoBehaviour
{
    // any GameObject that collides with this trigger will be destroyed
    private void OnTriggerEnter(Collider other) => Destroy(other.gameObject);
}
