using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public int Score;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            Debug.Log("Player collided with Key");
            Destroy(gameObject);
            GameController.instance.totalScore += Score;
            GameController.instance.UpdateScoreText();  
        }
    }
 }
