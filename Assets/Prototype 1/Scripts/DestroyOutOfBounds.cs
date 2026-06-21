using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30; // z position in which the game object should be deleted
    private float lowerBound = 0; // z position in which the game object should be deleted

    void Start()
    {
        
    }

    
    void Update()
    {
       if (transform.position.z > topBound) // check if object has hit top boundary
        {
            Destroy(gameObject); // destroy game object if it has hit game boundary

        } else if (transform.position.z < lowerBound) // check if object has hit Bottom boundary
        {
            if (gameObject.CompareTag("Animal")) // double check to ensure object was an animal
            {
                LifeManager.Instance.LoseLife(); // if animal gets to the bottom boundary, cause player to lose life
            }

            Destroy(gameObject); // destroy game object if it has hit game boundary
        }
    }
}
