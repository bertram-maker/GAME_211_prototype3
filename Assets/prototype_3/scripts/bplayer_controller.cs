using UnityEngine;
using UnityEngine.InputSystem;

public class bplayer_controller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody2D RB;
    private Vector2 velocity;
    public float speed;
    public float rotationSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        velocity = Vector2.zero;
        if (Keyboard.current.upArrowKey.isPressed)
        {
            velocity.y += speed;
        }
        if (Keyboard.current.downArrowKey.isPressed)
        {
            velocity.y -= speed;
        }
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            velocity.x -= speed;
        }
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            velocity.x += speed;
        }
        RB.linearVelocity = velocity;
        transform.Rotate(new  Vector3(0, 0, rotationSpeed));
    }
}
