using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
    public GameObject target;
    public float TargetDistance;
    public float AllowedDistance = 5;
    public GameObject TheNPC;
    public float FollowSpeed;
    public RaycastHit Shot;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target.transform);
        if(Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),out Shot)){
           TargetDistance = Shot.distance;
           if(TargetDistance >= AllowedDistance){
            FollowSpeed = 0.3f;
            TheNPC.GetComponent<Animation>().Play("TALKING");
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, FollowSpeed);
           } 
           else{
            FollowSpeed = 0;
            TheNPC.GetComponent<Animation>().Play("BREATHING");
           }
        }
    }
}
