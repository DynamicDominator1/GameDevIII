using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputAction moveAction; // input action (WASD) used to check if player wants to move
    public Vector2 moveInput; // stores input value for left and right
    public float speed = 10.0f; // player movement speed, editable in inspector
    public float xRange = 10.0f; // movement bounds, editable in inspector
    public GameObject projectilePrefab; // prefab for apple object spawned when player fires
    public InputAction fireApple; // input action (space bar) used to check if player has fired

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction.Enable();
        fireApple.Enable();

        // enables game to listen for input from move and fire buttons
    }

    // Update is called once per frame
    void Update()
    {
       // keep player in bounds
        if (transform.position.x < -xRange) // check if player has hit Left game boundary
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z); // clamps player object position to Left boundary
        }

        if (transform.position.x > xRange) // check if player has hit Right game boundary
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z); // clamps player object position to Right boundary
        } 

        moveInput = moveAction.ReadValue<Vector2>(); // reads current move input value ( -1 = Left, 0 = no movement, 1 = Right)
        transform.Translate(Vector3.right * moveInput.x * Time.deltaTime * speed); // transform character object position based on speed, moveInput and game time

        if (fireApple.triggered) //Space bar pressed
        {
            Debug.Log("fireApple triggered"); // check to ensure apple will fire

            
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation); // launch projectile from the player
        }
    }
}
