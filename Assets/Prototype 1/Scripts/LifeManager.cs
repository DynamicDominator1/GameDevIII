using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class LifeManager : MonoBehaviour
{
    public static LifeManager Instance;

    public GameObject LifeApple1;
    public GameObject LifeApple2;
    public GameObject LifeApple3;
    //references to game objects for each player life


    private int lives = 3; // Tracks player lives starting at 3

    private bool isGameOver = false; //tracks if game over

    void Awake()
    {
        Instance = this; //assign object as instance so it can be accessed globally from other scripts
    }

    void Update()
    {
        if (isGameOver && Keyboard.current.spaceKey.wasPressedThisFrame) // check if game over and if player has pressed space key
        {
            Debug.Log("GAME RESTART STARTED"); // logs restart has begun
            Time.timeScale = 1f; // sets game time back to normal speed
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // reloads current scene from beginning
            Debug.Log("GAME RESTART COMPLETED"); // logs restart has completed successfully
        }
    }

    public void LoseLife() // called when player loses a life
    {
        if (lives == 3) Destroy(LifeApple3); // if on 3rd life, delete LifeApple3
        else if (lives == 2) Destroy(LifeApple2); // if on 2nd life, delete LifeApple2
        else if (lives == 1) // if on last life, end game by doing the following
        {
            Destroy(LifeApple1); // delete LifeApple1
            isGameOver = true; // set game over
            Time.timeScale = 0f; // set game speed to 0
        }

        lives--; // decrease lives by 1
    }
}