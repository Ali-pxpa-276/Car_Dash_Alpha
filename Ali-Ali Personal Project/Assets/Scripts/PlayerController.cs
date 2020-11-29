using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float speed = 10.0f;
    private float xRange = 13f;
    private float zRange = 12f;
    private float zRange2 = 0f;

    private Rigidbody PlayerRb;
    // Start is called before the first frame update
    void Start()
    {
        PlayerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
        limitPlayerPosition();



    }

    // allows player to move through arrow keys
    void movePlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        float verticalInput = Input.GetAxis("Vertical");
         transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

      //  PlayerRb.AddForce(Vector3.forward * speed * verticalInput);
      //  PlayerRb.AddForce(Vector3.right * speed * horizontalInput);
    }


    // sets boundaries so player doesnt not  fall off the map
    void limitPlayerPosition()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);

        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);

        }

        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);

        }

        if (transform.position.z < zRange2)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange2);

        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Traffic"))
        {
            Debug.Log("player collided with traffic");
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
        }
    }
}

