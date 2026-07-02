using UnityEngine;

public class Laser : MonoBehaviour

{
[SerializeField] private float Laserspeed = 8f;


    void Start()
    {
        
    }

    
    void Update()
    {
        //tranform the laser position, and make it move forward(up) with a speed of 8 units per second
        transform.Translate(Vector3.up * Laserspeed * Time.deltaTime);
        //if the laser position on the y axis is greater than 7, then destroy the laser game object
        if (transform.position.y > 7f)
        {
            Destroy(gameObject);
        }

        
    }

    
}
