using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ResponseSlot : MonoBehaviour, IPointerClickHandler{

	public Talk talk;
	Button responseButton;
	Text responseSpeech;
	int nextID;
	
	// Use this for initialization
	void Start () {
		
		responseButton = gameObject.transform.GetChild (0).GetComponent<Button> ();
		responseSpeech = gameObject.transform.GetChild (1).GetComponent<Text> ();
	}
	
	// Update is called once per frame
	/*void Update () {
		if (talk != null) {
			responseButton.enabled = true;
			nextID = talk.talkNextID;
			responseSpeech.enabled = true;
			responseSpeech.text = talk.talkResponse;
		}else {
		//	responseButton.enabled = false;
			//responseSpeech.enabled = false;
		}
	} */

	public void OnPointerClick(PointerEventData data) {

		Debug.Log (transform.name);
	}
}
