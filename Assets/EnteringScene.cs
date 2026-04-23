using UnityEngine;

public class EnteringScene : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision entered");
    }
}