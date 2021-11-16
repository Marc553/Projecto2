using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    public float Speed = 10f;
    public float Speed1 = 10f;
    public float xRange = 16;
    public float zRange = 16;
    public float menoszRange = -1.5f;
 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * Speed * Time.deltaTime * horizontalInput);
        transform.Translate(Vector3.forward * Speed1 * Time.deltaTime * verticalInput);

        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        
        if(transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
       
        if(transform.position.z < menoszRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, menoszRange);
        }
        
    }
}
