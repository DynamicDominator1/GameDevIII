using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40.0f; //movement speed, editable in unity inspector

    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime *  speed); //Moves game object forward along z axis
    }
}
