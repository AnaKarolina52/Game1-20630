using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saw : MonoBehaviour
{
    public float speed;
    public float moveTime;


    private bool dirRight = true;
    private float time;

    // Update is called once per frame
    void Update()
    {
        if(dirRight)
        {
            //if is true the saw goes to right
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else
        {
            //if is false the saw goes to left
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        time += Time.deltaTime;

        if(time >= moveTime)
        {
            dirRight = !dirRight;
            time = 0f;
        }
        
    }
}
