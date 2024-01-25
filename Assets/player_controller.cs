using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{

    //writing extra stuff
    //do m,ore stuff
    //all testing for git
    //variables
    [SerializeField] float steer_speed = 1f;
    [SerializeField] float drive_speed = 20f;
    [SerializeField] float slow_speed = 15f;
    [SerializeField] float fast_speed = 30f;



    // Start is called before the first frame update
    void Start()
    {
        print("github do u see me?");
    }

    // Update is called once per frame
    void Update()
    {
        float steer_amount = Input.GetAxis("Horizontal") * steer_speed * Time.deltaTime;
        float move_amount = Input.GetAxis("Vertical") * drive_speed * Time.deltaTime;
        transform.Rotate(0, 0, -steer_amount);
        transform.Translate(0, move_amount, 0);
    }

    void OnCollisionEnter2D(Collision2D other) //this and tjhe other collision void dont execute together.
    {
        drive_speed = slow_speed;
        //How to make this return to normal speed.
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Boost")
        {
            print("boosted!");
            drive_speed = fast_speed;
            Destroy(other.gameObject); //Destroy the boost. No arg 1 means default instadestroy
        }
    }
}
