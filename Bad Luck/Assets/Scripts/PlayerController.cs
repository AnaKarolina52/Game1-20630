using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
/*
//lives
public Image Heart;
public int CantDeHeart;
public RectTransform PosicionPrimerHeart;
public Canvas MyCanvas;
public int OffSet;
//
*/

    // Start is called before the first frame update
    void Start()
    {
        /*
        //lives
        Transform PosHeart = PosicionPrimerHeart;
        for (int i = 0; i < CantDeHeart; i++)
        {
            Image NewHeart = Instantiate(Heart, PosHeart.position, Quaternion.identity);
            NewHeart.transform.parent = MyCanvas.transform;
            PosHeart.position = new Vector2(PosHeart.position.x + OffSet, PosHeart.position.y);
        }
        //
        */

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {   

        if (collision.gameObject.tag == "enemy")
        {
            FindObjectOfType<AudioManager>().Play("enemy");
            Debug.Log("Oh No!Its an enemy I'm...........");
            GameController.instance.ShowGameOver();
            Destroy(gameObject);

            /*
           //lives
            Destroy(MyCanvas.transform.GetChild(CantDeHeart + 1).gameObject);
            CantDeHeart -= 1;
            Debug.Log("One Heart Removed");
            //
            */

        }
            /*
         if (CantDeHeart < 1)
         {
            Debug.Log("No more hearts");
            GameController.instance.ShowGameOver();
            Destroy(gameObject);
            Destroy(Heart);
         }
         //
         */

        
        if (collision.gameObject.tag == "Spike")
        {
            FindObjectOfType<AudioManager>().Play("spike");
            Debug.Log("Ouch! It's a spike, wait it's a poison spike Ooowww");

            GameController.instance.ShowGameOver();
            Destroy(gameObject);
        }

         if (collision.gameObject.tag == "Saw")
        {
            FindObjectOfType<AudioManager>().Play("saw");
            Debug.Log(" A saw curious, Ooopss");

            GameController.instance.ShowGameOver();
            Destroy(gameObject);
        }

        if(collision.gameObject.tag == "Trophy") 
       {
            FindObjectOfType<AudioManager>().Play("Winner");
            Debug.Log("OHHHH I'm finally found, this mean: I'M THE CHAMPION");

            GameController.instance.GameCompleted();
            Destroy(gameObject);
           
        }
    
    }
    
}
