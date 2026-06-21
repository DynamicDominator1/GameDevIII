using UnityEngine;

public class LifeCount : MonoBehaviour
{

    public float speed = 90f; // Rotation speed in degrees per second, editable in Inspector

    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Rotate(Vector3.up *  speed * Time.deltaTime); // Rotates the object around the Y axis by speed and frame time
    }
}
