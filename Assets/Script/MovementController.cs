using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementController : MonoBehaviour
{
    [SerializeField] Transform playerTransform;

    PlayerInputs playerInputs;

    [SerializeField] private float movementModifier, cameraSensitivity;

    private float correctedYRotation;

    [SerializeField] Camera playerCamera;

    Vector2 movementVector, mouseMovementVector; // X Y


    void Start()
    {
        movementVector = Vector2.zero;
        playerInputs = new PlayerInputs();
        playerInputs.Enable();

        playerInputs.PlayerActionMap.Movement.performed += OnMove;
        playerInputs.PlayerActionMap.Movement.canceled += OnStopMovement;
        // playerInputs.PlayerActionMap.OnMouseMove.performed += OnMouseMove;
    }
    //
    // private void OnMouseMove(InputAction.CallbackContext obj)
    // {
    //     mouseMovementVector = obj.ReadValue<Vector2>();
    //     transform.Rotate(Vector3.up * mouseMovementVector.x * cameraSensitivity);
    //
    //     correctedYRotation -= mouseMovementVector.y;
    //     correctedYRotation = Mathf.Clamp(correctedYRotation, -4f, 20f);
    //     playerCamera.transform.localRotation = Quaternion.Euler(correctedYRotation, 0, 0);
    //
    //
    //     // mouseMovementVector = Vector2.zero;
    // }

    private void OnStopMovement(InputAction.CallbackContext obj)
    {
        movementVector = Vector2.zero;
    }

    private void OnMove(InputAction.CallbackContext obj)
    {
        movementVector = obj.ReadValue<Vector2>();
    }

    void Update()
    {
        transform.position = new Vector3(
            transform.position.x + movementVector.x * movementModifier * Time.deltaTime,
            transform.position.y,
            transform.position.z + movementVector.y * movementModifier * Time.deltaTime
        );
    }
}