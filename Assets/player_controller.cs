using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{

    //variables
    [SerializeField] float steer_speed = 0.25f;
    [SerializeField] float drive_speed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steer_amount = Input.GetAxis("Horizontal") * steer_speed * Time.deltaTime;
        float move_amount = Input.GetAxis("Vertical") * drive_speed * Time.deltaTime;
        transform.Rotate(0, 0, -steer_amount);
        transform.Translate(0, move_amount, 0);
    }
}
