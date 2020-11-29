using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 5.0f;
    private float destroyZ = -2;
    private Rigidbody objectRB;
    void Start()
    {
        objectRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        objectRB.AddForce(Vector3.forward * -speed);

        if(transform.position.z < destroyZ)
        {
            Destroy(gameObject);
        }

    }
}
