using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow_camera : MonoBehaviour
{
    [SerializeField] GameObject thing_to_follow;

    //Late update 
    void LateUpdate()
    {
        transform.position = thing_to_follow.transform.position + new Vector3 (0, 0, -10);
    }
}
