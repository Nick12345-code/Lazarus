using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;   
    private Vector3 movement;
    private Rigidbody rb;

    private void Start() => rb = GetComponent<Rigidbody>();

    private void Update() => Move();

    // movement vector is normalized so player moves identically in every direction (diagonal movement would be faster otherwise)
    private void FixedUpdate() => rb.MovePosition(rb.position + movement.normalized * speed * Time.fixedDeltaTime);

    private void Move()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.z = Input.GetAxisRaw("Vertical");
    }


}
