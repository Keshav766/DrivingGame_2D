using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
   
    [SerializeField] GameObject thingToFollow; 
//    the cameras position should match the car's as the car moves
    void Update()
    {
        transform.position = thingToFollow.transform.position + new Vector3 (0, 0, -10);
    }
}
