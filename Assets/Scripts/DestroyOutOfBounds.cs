using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float upperLimit = 30f;
    private float lowerLimit = -10f;

    void Update()
    {
       //Bala fallida
       if(transform.position.z > upperLimit)
        {
            Destroy(gameObject);
        }

       //Animal que cruza
       if(transform.position.z < lowerLimit)
        {
            Destroy(gameObject);
            Time.timeScale = 0;
        }
    }
}
