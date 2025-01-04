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

    private void Update()
    {
        // Basic player movement
        float moveX = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
        float moveZ = Input.GetAxis("Vertical") * Speed * Time.deltaTime;

        transform.Translate(moveX, 0, moveZ);
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