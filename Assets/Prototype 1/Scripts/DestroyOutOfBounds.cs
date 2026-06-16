using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = 0;

    void Start()
    {
        
    }

    
    void Update()
    {
       if (transform.position.z > topBound)
        {
            Destroy(gameObject);

        } else if (transform.position.z < lowerBound)
        {
            if (gameObject.CompareTag("Animal"))
            {
                LifeManager.Instance.LoseLife();
            }

            Destroy(gameObject);
        }
    }
}
