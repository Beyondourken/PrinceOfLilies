using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;

public class GuardConversation : MonoBehaviour {


	public Sprite icon;
	private ModalPanel modalPanel;
	private bool isBellRung = false;
	private int timesBellRung = 0;

	TalkDataBase database;   //*************************
	Talk talk;   //current conversation ******************************
	int currentTalk = 0; //**************************************************************
	//	private UnityAction myResponse1Action;
	//	private UnityAction myResponse2Action;
	//	private UnityAction myResponse3Action;

	void Awake() {

		modalPanel = ModalPanel.Instance ();

		database = GameObject.FindGameObjectWithTag ("TalkDatabase").GetComponent<TalkDataBase>(); //********************************

		//	myResponse1Action = new UnityAction (TestResponse1);
		//	myResponse2Action = new UnityAction (TestResponse2);
		//	myResponse3Action = new UnityAction (TestResponse3);
	}

	//send to the modal panel to set up the buttons and functions to call

//	public void TestButtons() {
		//modalPanel.Choice ("Please make a choice\nTest them all", myResponse1Action, myResponse2Action, myResponse3Action);
//		modalPanel.Choice ("Please make a choice\nTest them all", TestResponse1, TestResponse2,TestResponse3);
//	}

//	public void TestButtonsImage() {

//		modalPanel.Choice ("This is the guard\nPlease test the buttons below", icon, TestResponse1, TestResponse2,TestResponse3);
//	}

	public void OnTriggerEnter(Collider col) {
		
		// If the colliding gameobject is the player...
		if (col.CompareTag ("Player")) {
			Debug.Log ("guard trigger");
			if (isBellRung) {
				currentTalk = timesBellRung;
				isBellRung = false;
			}

			talk = database.talkList [currentTalk];
			modalPanel.Choice (talk.talkSpeech, icon, talk.talkResponse, TestResponse1, talk.talkResponse1, TestResponse2, talk.talkResponse2, TestResponse3);
		}
	}

	//these are wrapped into unity actions

	void TestResponse1() {
		Debug.Log ("Response1");
		Debug.Log (talk.isImmediate);
		currentTalk = talk.talkNextID;
		if (talk.isImmediate) {
			//TestButtonsText (); 
		}
	}

	void TestResponse2() {
		Debug.Log ("Response2");
		Debug.Log (talk.isImmediate1);
		currentTalk = talk.talkNextID1;
		if (talk.isImmediate1) {
			//TestButtonsText (); 
		}
	}
	void TestResponse3() {
		Debug.Log ("Response3");
		Debug.Log (talk.isImmediate2);
		currentTalk = talk.talkNextID2;
		if (talk.isImmediate2== true) {
			Debug.Log ("immediate");
			//TestButtonsText (); 
		}
	}

	public void BellRung() {
		isBellRung = true;
		timesBellRung++;
		if (timesBellRung > 3) timesBellRung = 0;
	}
}