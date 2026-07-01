using UnityEngine;

public class Enemy : MonoBehaviour
{
   [SerializeField] private float _moveSpeed = 4f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // after enemy spawn, make it move down with a speed of 4 units per second
        transform.Translate(new Vector3(0, -_moveSpeed, 0) * Time.deltaTime);
        // if enemy is at botton of screen teleport enemy to random location within screen width and top of screen
        if (transform.position.y < -5.58f)
        //if (!GetComponent<Renderer>().isVisible)
        {
            transform.position = new Vector3(Random.Range(-9.14f, 9.14f), 5.58f, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Laser")
        Destroy(this.gameObject);
        Destroy(other.gameObject);
        Debug.Log(other.transform.name);
    }
}
