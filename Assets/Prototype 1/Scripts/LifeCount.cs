using UnityEngine;

public class LifeCount : MonoBehaviour
{

    public float speed = 90f;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Rotate(Vector3.up *  speed * Time.deltaTime);
    }
}
