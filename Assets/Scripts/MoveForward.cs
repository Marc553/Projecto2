using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    //La velocidad que alcanzará 
    public float Speed = 5f;
    private float zRangeUp = 20;

    // Update is called once per frame
    void Update()
    {
        //Da la orden para moverse en Z
     
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);

        //Limite de pantalla por arriba 
        /*if (transform.position.z > zRangeUp)
        {
            Destroy(gameObject);
        }*/

    }


}
