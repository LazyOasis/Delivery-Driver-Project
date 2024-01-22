using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("COLLIDED WTF");   
    }

   
    void OnTriggerEnter2D(Collider2D other)
    {   
        //Notice how this only triggers once per "entrance"
        Debug.Log("TRIGGERED WTF");  
    }
   
}
