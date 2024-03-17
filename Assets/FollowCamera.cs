using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;
    // this things position (camera) should be the same as the car's position
    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + new Vector3 (-13,1.7f,-929.5f);
    }
}
