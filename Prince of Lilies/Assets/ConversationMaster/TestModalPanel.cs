using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;

public class TestModalPanel : MonoBehaviour {

	public Sprite icon;
	private ModalPanel modalPanel;

//	private UnityAction myResponse1Action;
//	private UnityAction myResponse2Action;
//	private UnityAction myResponse3Action;

	void Awake() {

		modalPanel = ModalPanel.Instance ();

	//	myResponse1Action = new UnityAction (TestResponse1);
	//	myResponse2Action = new UnityAction (TestResponse2);
	//	myResponse3Action = new UnityAction (TestResponse3);
	}

	//send to the modal panel to set up the buttons and functions to call

	public void TestButtons() {
		//modalPanel.Choice ("Please make a choice\nTest them all", myResponse1Action, myResponse2Action, myResponse3Action);
		modalPanel.Choice ("Please make a choice\nTest them all", TestResponse1, TestResponse2,TestResponse3);
	}

	public void TestButtonsImage() {
		
		modalPanel.Choice ("This is the guard\nPlease test the buttons below", icon, TestResponse1, TestResponse2,TestResponse3);
	}

	//these are wrapped into unity actions

	void TestResponse1() {
		Debug.Log ("Response1");
	}

	void TestResponse2() {
		Debug.Log ("Response2");
	}
	void TestResponse3() {
		Debug.Log ("Response3");
	}

}