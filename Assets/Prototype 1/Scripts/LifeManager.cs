using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class LifeManager : MonoBehaviour
{
    public static LifeManager Instance;

    public GameObject LifeApple1;
    public GameObject LifeApple2;
    public GameObject LifeApple3;

    public InputAction fireApple;

    private int lives = 3;
    private bool isGameOver = false;

    void Awake()
    {
        Instance = this;
    }

    void Update()
    {
        if (isGameOver && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Debug.Log("GAME RESTART STARTED");
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Debug.Log("GAME RESTART COMPLETED");
        }
    }

    public void LoseLife()
    {
        if (lives == 3) Destroy(LifeApple3);
        else if (lives == 2) Destroy(LifeApple2);
        else if (lives == 1)
        {
            Destroy(LifeApple1);
            isGameOver = true;
            Time.timeScale = 0f;
        }

        lives--;
    }
}