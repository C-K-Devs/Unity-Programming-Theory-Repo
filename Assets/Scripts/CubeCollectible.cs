using UnityEngine;

// INHERITANCE
// The CubeCollectible class inherits from the Collectible base class
public class CubeCollectible : Collectible
{
    // POLYMORPHISM
    // Overriding the OnCollect method to define specific behavior for this collectible
    public override void OnCollect()
    {
        Debug.Log("Cube collected!");
        Destroy(gameObject); // Remove the cube from the scene
    }
}