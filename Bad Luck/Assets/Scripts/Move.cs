using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 6; 

    void FixedUpdate() {
        // Check Input Axes

        float h = Input.GetAxisRaw("Horizontal");  
        float v = Input.GetAxisRaw("Vertical");
        GetComponent<Rigidbody2D>().velocity =  new Vector2(h, v)  * speed;

        // Set Animation Parameters   
        GetComponent<Animator>().SetInteger("X", (int)h);     
        GetComponent<Animator>().SetInteger("Y", (int)v);

    }
}
