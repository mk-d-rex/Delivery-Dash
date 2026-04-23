using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision detected");
    }
}
