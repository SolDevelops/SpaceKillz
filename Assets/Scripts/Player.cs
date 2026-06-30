using UnityEngine;

public class Player : MonoBehaviour
{
  
    [SerializeField] private float _speed =5f;
    void Start()
    {
        // take players current position = new postion of (0, 0, 0)
        transform.position = new Vector3(0, 0, 0);
    }

    
    void Update()
    {
        //Make character move with input from keyboard

    //1. create and get the input type/axis(float, int, horizontal, vertical, etc.), then get the axis you need for player input movement
    //2. get the input from that axis
    //3. multiply the input by variable _speed you created and time.deltaTime

        float horizontalInput = Input.GetAxis("Horizontal"); // Input.GetAxis("Horizontal") gets the input from that axis
        float verticalInput = Input.GetAxis("Vertical"); //Input.GetAxis("Vertical") gets the input from that axis


       //transform.Translate(Vector3.right * horizontalInput * _speed * Time.deltaTime); //makes the player move right and left with the horizontal input
       //transform.Translate(Vector3.up * verticalInput * _speed * Time.deltaTime); //makes the player move up and down with the vertical input


        //more efficient way to write the code above is to combine the two lines of code into one line of code, like this:
        
        //1. create a new Vector3 with the horizontal and vertical input, then multiply that by the speed and time.deltaTime
        transform.Translate(new Vector3(horizontalInput, verticalInput, 0)* _speed *Time.deltaTime); //makes the player move in all directions with the horizontal and vertical input
        
        
    }
}
