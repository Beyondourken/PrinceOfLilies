using UnityEngine;
using System.Collections;

public class Bell : MonoBehaviour {
	
	//private GameObject player;              // Reference to the player.
	public GameObject setTargetOn;
	public GameObject ikController;

	private bool isBellRung = false;
	private Transform clapper;

	
	void OnTriggerStay (Collider col)
	{
		// If the colliding gameobject is the player...
		if (col.CompareTag("Player")) {
			// ... and the switch button is pressed...
			if (Input.GetButton ("Submit") && !isBellRung) {
				isBellRung = true; 

				foreach (Transform t in transform)
				{
					if(t.name == "Clapper") {
						clapper = t.transform;
					}
				}

				ikController.SendMessage("SetTarget",clapper); //player hand to bell
				ikController.SendMessage("SetEnabled");
				RingBell ();
				StartCoroutine(Waiting());

			}
		}
	}
	
	
	void RingBell ()
	{

		// Play alarm bell audio clip.
		GetComponent<AudioSource>().Play();
		GetComponent<Animator> ().SetBool ("IsRinging", true);
	
				
	
	}
	IEnumerator Waiting() {
		yield return new WaitForSeconds(.5f);
		
		ikController.SendMessage("SetEnabled");  //player detach from bell
		setTargetOn.SendMessage ("SetTarget", transform); //send guard to bell
		isBellRung = false;
		GetComponent<Animator> ().SetBool ("IsRinging", false);
	}

}


		

