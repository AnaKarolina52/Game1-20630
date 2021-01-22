using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawLeft : MonoBehaviour
{
    public float speed;
    public float moveTime;


    private bool dirLeft = true;
    private float time;

    // Update is called once per frame
    void Update()
    {
        if(dirLeft)
        {
            //if is true the saw goes to right
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        else
        {
            //if is false the saw goes to left
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }

        time += Time.deltaTime;

        if(time >= moveTime)
        {
            dirLeft = !dirLeft;
            time = 0f;
        }
        
    }
}

