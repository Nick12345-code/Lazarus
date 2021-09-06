using UnityEngine;

public class CameraController : MonoBehaviour
{
    [Header("Look")]
    [SerializeField, Range(1, 10)] private float speed;
    [SerializeField, Range(1, 180)] private float upLimit;
    [SerializeField, Range(-90, 180)] private float downLimit;
    [SerializeField, Range(1, 180)] private float leftLimit;
    [SerializeField, Range(1, 180)] private float rightLimit;
    private float rotationX = 0.0f;
    private float rotationY = 0.0f;


    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        Look();
    }

    private void Look()
    {
        // clamps up and down movement
        rotationX -= Input.GetAxis("Mouse Y") * speed;
        rotationX = Mathf.Clamp(rotationX, -upLimit, downLimit);

        // clamps left and right movement
        rotationY += Input.GetAxis("Mouse X") * speed;
        rotationY = Mathf.Clamp(rotationY, -leftLimit, rightLimit);

        // camera rotates locally
        transform.localRotation = Quaternion.Euler(rotationX, rotationY, 0);

        // rotates the camera according the mouse position and speed 
        transform.rotation *= Quaternion.Euler(Input.GetAxis("Mouse Y") * speed, Input.GetAxis("Mouse X") * speed, 0);
    }
}
