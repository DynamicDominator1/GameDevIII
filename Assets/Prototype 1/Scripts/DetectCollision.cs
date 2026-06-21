using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) // Called automatically when object's collider enters another object's trigger collider
    {
        Destroy(gameObject); // Destory this object
        Destroy(other.gameObject); // destroy the object that this object collided with
    }
}
