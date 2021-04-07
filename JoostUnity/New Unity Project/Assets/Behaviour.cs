using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Behaviour : MonoBehaviour
{
    public float speed = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -5 || transform.position.x >= 0)
        {
            transform.position += new Vector3(speed, 0, 0);
        }
        else if (transform.position.x >= 5 || transform.position.x >= 0)
        {
            transform.position -= new Vector3(speed, 0, 0);
        }
        Debug.Log(gameObject.transform.position);
    }
}
