using UnityEngine;
using UnityEngine.InputSystem;

public class CarMovement : MonoBehaviour
{
    [Header("Speed Settings")]
    public float baseSpeed = 10f;
    public float nitroSpeed = 20f;

    private float currentSpeed;

    void Start()
    {
        currentSpeed = baseSpeed;
    }

    void Update()
    {
        HandleNitro();
        MoveForward();
    }

    void MoveForward()
    {
        transform.Translate(Vector3.forward * currentSpeed * Time.deltaTime);
    }

    void HandleNitro()
    {
        if (Keyboard.current.spaceKey.isPressed)
        {
            currentSpeed = nitroSpeed;
        }
        else
        {
            currentSpeed = baseSpeed;
        }
    }
}
