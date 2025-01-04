using UnityEngine;

// ABSTRACTION
// This base class defines the core behavior for any collectible item
public abstract class Collectible : MonoBehaviour
{
    public abstract void OnCollect(); // Abstract method to be overridden by child classes
}
