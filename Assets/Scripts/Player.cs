using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    public float Speed = 10f;
    public float Speed1 = 10f;
    private float xRange = 16;
    private float zRangeUp = 16;
    private float zRangeDown = -1.5f;

    public GameObject projectilPrefab;
 

    void Start()
    {
       
    }


    void Update()
    {

        //Configura los inputs horizontales y verticales 
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
       
        //Da la orden a los inputs previamente configurados: la 1 es para moverse en X y el 2 para moverse en Z
        transform.Translate(Vector3.right * Speed * Time.deltaTime * horizontalInput);
        transform.Translate(Vector3.forward * Speed1 * Time.deltaTime * verticalInput);

        //Limite de pantalla por la derecha
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        //Limite de pantalla por la izquierda
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        //Limite de pantalla por arriba 
        if (transform.position.z > zRangeUp)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRangeUp);
        }

        //Limite de pantalla por abajo
        if (transform.position.z < zRangeDown)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRangeDown);
        }
        
        //Disparo 
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilPrefab, transform.position, projectilPrefab.transform.rotation);
        }

    }
}
