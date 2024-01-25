using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 has_package_colour = new Color32 (1, 1, 1, 1);
    [SerializeField] Color32 no_package_colour = new Color32 (1, 1, 1, 1);
    bool has_package = false;

    SpriteRenderer sprite_renderer;
    [SerializeField] private float destroy_delay = 0f;
    
    void Start()
    {
        sprite_renderer = GetComponent<SpriteRenderer>();
        sprite_renderer.color = no_package_colour;
    }
    //IM WRITING THIS FROM MY MACBOOK BRO WHATTTTT
    void OnCollisionEnter2D(Collision2D other)
    {
        //Debug.Log("COLLIDED WTF");   
    }

   
    void OnTriggerEnter2D(Collider2D other) //This returns the "other"
    {   
        //Notice how this only triggers once per "entrance"
        //Debug.Log("TRIGGERED WTF");  

        if (other.tag == "Package" && has_package == false)
        {
            print("Package picked up");
            has_package = true;
            sprite_renderer.color = has_package_colour;
            //Destroy(obj, time to destroy)
            Destroy(other.gameObject, destroy_delay);
        }

        if(other.tag == "Customer" && has_package == true)
        {
            print("Package Delivered!");
            sprite_renderer.color = no_package_colour;
            has_package = false;
        }
    }
   
}
