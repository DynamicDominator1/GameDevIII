using UnityEngine;
using UnityEngine.InputSystem;

public class ClickMaster : MonoBehaviour
{

    public GameObject IdleCapy;
    public GameObject ActiveCapy;

    public float swapTime = 0.5f;
    public float swapTimer = 0f;
    public bool isSwapped = false;
    public float swapCooldown = 1f;
    public float cooldownTimer = 0f;

    public int pointsTotal = 0;
    public int pointsPerClick = 1;
    public int pointsPerSecond = 0;
    public float passiveTimer = 0;

   
    void Update()
    {
        /* 
         
         bool anyKeyPressed = Keyboard.current.anyKey.wasPressedThisFrame;

         IdleCapy.SetActive(!anyKeyPressed);
         ActiveCapy.SetActive(anyKeyPressed); 
        
         */

        cooldownTimer += Time.deltaTime;

        if (Keyboard.current.anyKey.wasPressedThisFrame)
        {

            pointsTotal += pointsPerClick;

            Debug.Log("Points: " + pointsTotal);

            if (cooldownTimer >= swapCooldown)
            {
                isSwapped = true;
                swapTimer = 0f;
                cooldownTimer = 0f;
            }
                
        }

        if (isSwapped)
        {
            swapTimer += Time.deltaTime;
            if (swapTimer >= swapTime)
            {
                isSwapped = false;
            }
        }

        if (pointsPerSecond > 0)
        {
            passiveTimer += Time.deltaTime;

            if (passiveTimer >= 1f)
            {
                pointsTotal += pointsPerSecond;
                passiveTimer = 0f;
            }
        }


        IdleCapy.SetActive(!isSwapped);
        ActiveCapy.SetActive(isSwapped);
    }

}


