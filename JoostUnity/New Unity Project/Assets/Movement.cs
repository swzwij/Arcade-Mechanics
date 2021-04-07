using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float movementSpeed = 0.0f;
    public float jumpHeight = 0.0f;
    public float rotationSpeed = 0.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-1, 0, 0) * Time.deltaTime * movementSpeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(1, 0, 0) * Time.deltaTime * movementSpeed;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 0, 1) * Time.deltaTime * movementSpeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, 0, -1) * Time.deltaTime * movementSpeed;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += new Vector3(0, 1, 0) * Time.deltaTime * jumpHeight;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation += new V(0, 10, 0) * Time.deltaTime * rotationSpeed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.rotation += new Quaternion.Euler(0, 10, 0) * Time.deltaTime * rotationSpeed;
        }
    }
}
