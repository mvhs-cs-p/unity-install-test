using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{

    public float moveSpeed = 5f;
    public float drag = 3f;
    public Vector2 velocity = Vector2.zero;


    // Update is called once per frame
    void Update()
    {
        Vector2 input = getPlayerInput();
        MovePlayer(input);
    }

    private Vector2 getPlayerInput()
    {
        Vector2 moveInput = Vector2.zero;
        if (Keyboard.current.wKey.isPressed)
        {
            moveInput.y += 1;
        }
        if (Keyboard.current.sKey.isPressed)
        {
            moveInput.y -= 1;
        }
        if (Keyboard.current.aKey.isPressed)
        {
            moveInput.x -= 1;
        }
        if (Keyboard.current.dKey.isPressed)
        {
            moveInput.x += 1;
        }

        return moveInput.normalized;
    }

    private void MovePlayer(Vector2 input)
    {
        velocity += input * moveSpeed * Time.deltaTime;
        velocity -= velocity * drag * Time.deltaTime;

        Vector2 moveAmount = velocity * Time.deltaTime;
        transform.Translate(moveAmount);
    }
}
