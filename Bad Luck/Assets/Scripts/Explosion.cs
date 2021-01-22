using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{

  void OnTriggerEnter2D(Collider2D co){   

    if (co.gameObject.tag == "block")
    {
      Destroy(co.gameObject);
    }

 
  if (co.gameObject.tag == "Player")
  {
      GameController.instance.ShowGameOver();
      Destroy(co.gameObject);
  }

  if (co.gameObject.tag == "enemy")
  {
      
      Destroy(co.gameObject);
  }


  /*
  else if (!co.gameObject.isStatic)
  {
        Destroy(co.gameObject); 
  }
  */
}

}



  