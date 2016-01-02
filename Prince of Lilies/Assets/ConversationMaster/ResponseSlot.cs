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
		
	}
	

	public void OnPointerClick(PointerEventData data) {

		Debug.Log (transform.parent.name);
		int nextID = System.Int32.Parse (transform.parent.name);
		gameObject.SendMessageUpwards ("SetCurrentTalk", nextID);
	}


}
