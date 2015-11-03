using UnityEngine;
using System.Collections;

public class Bell : MonoBehaviour {
	
	private GameObject player;              // Reference to the player.
	public GameObject setTargetOn;

	
	

	
	void OnTriggerStay (Collider col)
	{
		// If the colliding gameobject is the player...
		if (col.CompareTag("Player")) {
			// ... and the switch button is pressed...
			if (Input.GetButton ("Submit")) {
				
				RingBell ();

			}
		}
	}
	
	
	void RingBell ()
	{

		// Play allarm bell audio clip.
		GetComponent<AudioSource>().Play();
		setTargetOn.SendMessage("SetTarget", transform);
	
	}

}


		

