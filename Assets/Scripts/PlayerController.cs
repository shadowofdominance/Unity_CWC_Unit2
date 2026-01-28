using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class PlayerController : MonoBehaviour
{
    public InputActionAsset InputActions;

    public float playerSpeed;
    public float xRange = 15.0f;
    private InputAction moveAction;
    private InputAction attackAction;
    public GameObject projectilePrefab;

    private Vector2 moveAmount;
    private void OnEnable()
    {
        InputActions.FindActionMap("Player").Enable();
    }
    private void OnDisable()
    {
        InputActions.FindActionMap("Player").Disable();
    }

    private void Awake()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        attackAction = InputSystem.actions.FindAction("Attack");
    }

    // Update is called once per frame
    void Update()
    {
        //Helping player stay inside the boundary!
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        Vector2 moveInput = moveAction.ReadValue<Vector2>();

        //Debug.Log($"Move Input: {moveInput}");

        float horizontalInput = moveInput.x;

        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * playerSpeed);

        if (attackAction.WasPressedThisFrame())
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
