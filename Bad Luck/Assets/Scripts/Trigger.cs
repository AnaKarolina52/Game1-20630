using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
	public bool hasKey = false;
	public GameObject door;

	public void Start()
	{
		FindObjectOfType<AudioManager>().Play("Music");
	
	}


	private void OnTriggerEnter2D(Collider2D collision)
	{
	
		if (collision.gameObject.tag == "Key") {
			FindObjectOfType<AudioManager>().Play("pickup");
			Debug.Log ("You have the key, now you can open the door");
			hasKey = true;
			//collision.gameObject.SetActive(false);   
		}

		if (collision.gameObject.tag == "Door" && hasKey) {
			FindObjectOfType<AudioManager>().Play("doorOpen");
			
			hasKey = false;
			Debug.Log ("Door is unlocked");
			collision.gameObject.SetActive (false);

		}

		if (collision.gameObject.tag == "Door" && !hasKey) {
			FindObjectOfType<AudioManager>().Play("doorLocked");

			Debug.Log ("You need a Key to open this door");

			
		}
	}
}