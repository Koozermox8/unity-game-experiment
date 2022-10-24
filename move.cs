//class for tile-based movement in personal project
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour

{
    //movement speed in units per second
    private float movementSpeed = 5f;
    public Transform gridmover;

    void Update()
    {
         transform.position = Vector3.MoveTowards(transform.position, gridmover.position, movementSpeed * Time.deltaTime);
        if(Vector3.Distance(transform.position, gridmover.position) <= .05f) {
        //get the Input from Horizontal axis
         if (Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1) {
           gridmover.position += new Vector3(Input.GetAxisRaw("Horizontal"),0f,0f);
            }
         if(Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1) {
           gridmover.position += new Vector3(0f,Input.GetAxisRaw("Vertical"),0f);
       }
     }   
    }
}
