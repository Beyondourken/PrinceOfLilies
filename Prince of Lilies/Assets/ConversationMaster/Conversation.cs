using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Conversation : MonoBehaviour {

	public GameObject talkSlots;
	public GameObject responseSlots;


	public Talk talk;   //current conversation
	public List<GameObject> responses = new List<GameObject>();
	public List<Talk> talks = new List<Talk>();

	TalkDataBase database;

	Image speakerImage;
	Text speakerSpeech;
	Text response;

	int currentTalk = 0;

	// Use this for initialization
	void Start () {

		database = GameObject.FindGameObjectWithTag ("TalkDatabase").GetComponent<TalkDataBase>();
		int x = 2;
		int y = 36;
		GameObject talkSlot = (GameObject) Instantiate(talkSlots);
		talks.Add(new Talk());
		talkSlot.transform.SetParent(this.gameObject.transform);
		talkSlot.GetComponent<RectTransform>().localPosition = new Vector3(x,y,0);
		talkSlot.name = "" +0;
		y += -60;
	

		for (int i = 1; i<4; i++) {
			GameObject responseSlot = (GameObject) Instantiate(responseSlots);
			responses.Add(responseSlot);
			responseSlot.transform.SetParent(this.gameObject.transform);
			responseSlot.GetComponent<RectTransform>().localPosition = new Vector3(x,y,0);
			responseSlot.name = "" +i;
			y += -60;
		}

		speakerImage = gameObject.transform.GetChild (0).GetChild(0).GetChild (0).GetComponent<Image> ();
		speakerSpeech = gameObject.transform.GetChild (0).GetChild(1).GetComponent<Text> ();

		talk = database.talkList [currentTalk];

	}


	// Update is called once per frame
	void Update () {
		if (talk != null) {
			speakerImage.enabled = true;
			speakerImage.sprite = talk.talkSpeaker;
			speakerSpeech.enabled = true;
			speakerSpeech.text = talk.talkSpeech;
		//for (int i = 1; i<4; i++) {
				response = gameObject.transform.GetChild (1).GetChild (1).GetComponent<Text> ();
		//	Debug.Log ("response " +talk.talkResponse );
				response.enabled = true;
				response.text = talk.talkResponse;
			 Text response1 = gameObject.transform.GetChild (2).GetChild (1).GetComponent<Text> ();

			response1.enabled = true;
			response1.text = talk.talkResponse1;
		//	Debug.Log ("response1 " +talk.talkResponse1);
			Text response2 = gameObject.transform.GetChild (3).GetChild (1).GetComponent<Text> ();

			response2.enabled = true;
			response2.text = talk.talkResponse2;
		//	Debug.Log ("response2 " +talk.talkResponse2);
		//	}

		}else {
			speakerImage.enabled = false;
			speakerSpeech.enabled = false;
		}
	
	}


	void AddTalk(int id) {

		for (int i = 0; i < database.talkList.Count; i++) {
			if (database.talkList[i].talkID == id) {
				Talk talk = database.talkList[i];
				talks.Add(talk);
				break;
			}
		}
	}
}
