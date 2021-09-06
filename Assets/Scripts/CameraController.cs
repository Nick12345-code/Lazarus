using UnityEngine;

public class CameraController : MonoBehaviour
{
    [Header("Look")]
    [SerializeField, Range(1, 10)] private float lookSpeed = 2.0f;
    [SerializeField, Range(1, 180)] private float upperLookLimit = 80.0f;
    [SerializeField, Range(-90, 180)] private float lowerLookLimit = 80.0f;
    [SerializeField, Range(1, 180)] private float leftLookLimit = 80.0f;
    [SerializeField, Range(1, 180)] private float rightLookLimit = 80.0f;
    private Camera playerCamera;
    private float rotationX = 0.0f;
    private float rotationY = 0.0f;


    private void Start()
    {
        playerCamera = GetComponent<Camera>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        Look();
    }

    private void Look()
    {
        rotationX -= Input.GetAxis("Mouse Y") * lookSpeed;
        rotationX = Mathf.Clamp(rotationX, -upperLookLimit, lowerLookLimit);

        rotationY += Input.GetAxis("Mouse X") * lookSpeed;
        rotationY = Mathf.Clamp(rotationY, -leftLookLimit, rightLookLimit);

        playerCamera.transform.localRotation = Quaternion.Euler(rotationX, rotationY, 0);
        transform.rotation *= Quaternion.Euler(Input.GetAxis("Mouse Y") * lookSpeed, Input.GetAxis("Mouse X") * lookSpeed, 0);
    }
}
