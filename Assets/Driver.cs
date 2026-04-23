using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{
    [SerializeField] float moveSpeed = .1f; // Speed of forward/backward movement
    [SerializeField] float steerSpeed = 20f; // Speed of rotation (steering)

    // Update is called once per frame
    void Update()
    {
        float move = 0f; // Movement input: 1 for forward, -1 for backward
        float steer = 0f; // Steering input: 1 for left, -1 for right

        // Check keyboard input for movement
        if (Keyboard.current.wKey.isPressed)
        {
            move = 1f;
        }
        else if (Keyboard.current.sKey.isPressed)
        {
            move = -1f;
        }

        // Check keyboard input for steering
        if (Keyboard.current.aKey.isPressed)
        {
            steer = 1f;
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            steer = -1f;
        }

        // Calculate movement and steering amounts based on input and time
        float moveAmount = move * moveSpeed * Time.deltaTime;
        float steerAmount = steer * steerSpeed * Time.deltaTime;

        // Apply steering (rotation) and movement (translation)
        transform.Rotate(0, 0, steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
}
