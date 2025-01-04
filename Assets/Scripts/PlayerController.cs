using UnityEngine;

// This script controls the player's movement and handles interactions with collectibles
public class PlayerController : MonoBehaviour
{
    // ENCAPSULATION
    // Private field with public getter and setter for player's speed
    [SerializeField]
    private float _speed = 5f;

    public float Speed
    {
        get => _speed;
        set => _speed = Mathf.Clamp(value, 1f, 10f); // Clamping speed to a valid range
    }

    // Camera rotation variables
    [SerializeField]
    private float mouseSensitivity = 100f; // Adjust sensitivity for smoother rotation
    private float xRotation = 0f;        // Keeps track of vertical rotation

    public Transform cameraTransform; // Reference to the child camera transform

    private void Start()
    {
        // Lock the cursor to the game window and hide it
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        HandleMovement(); // Call movement logic
        HandleCameraRotation(); // Call camera rotation logic
    }

    private void HandleMovement()
    {
        // Basic player movement
        float moveX = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
        float moveZ = Input.GetAxis("Vertical") * Speed * Time.deltaTime;

        transform.Translate(moveX, 0, moveZ);
    }

    private void HandleCameraRotation()
    {
        // Get mouse input
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Rotate the player (horizontal rotation)
        transform.Rotate(Vector3.up * mouseX);

        // Rotate the camera (vertical rotation)
        xRotation -= mouseY; // Subtract to invert the Y-axis
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // Clamp vertical rotation to avoid flipping

        cameraTransform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the player collided with a collectible
        Collectible collectible = other.GetComponent<Collectible>();
        if (collectible != null)
        {
            collectible.OnCollect(); // Call the collectible's OnCollect method
        }
    }
}