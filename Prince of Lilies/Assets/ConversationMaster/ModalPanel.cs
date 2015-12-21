using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;

public class ModalPanel : MonoBehaviour {
	
	public GameObject modalPanelObject;

	public Image speakerImage;
	public Text speakerSpeech;

	public Button response1;
	public Button response2;
	public Button response3;

	private static ModalPanel modalPanel;

	public static ModalPanel Instance() {
		if (!modalPanel) {
			modalPanel = FindObjectOfType(typeof (ModalPanel)) as ModalPanel; 
			if (!modalPanel) {
				Debug.LogError ("There needs to be at least one active modalPanel script on a gameobject in this scene");
			}
		}
		return modalPanel;
	}


	// A string and three possible responses
	public void Choice( string speech, UnityAction response1Event, UnityAction response2Event, UnityAction response3Event) {
		modalPanelObject.SetActive (true);

		response1.onClick.RemoveAllListeners ();
		response1.onClick.AddListener (response1Event);
		response1.onClick.AddListener (ClosePanel);

		response2.onClick.RemoveAllListeners ();
		response2.onClick.AddListener (response2Event);
		response2.onClick.AddListener (ClosePanel);

		response3.onClick.RemoveAllListeners ();
		response3.onClick.AddListener (response3Event);
		response3.onClick.AddListener (ClosePanel);

		this.speakerSpeech.text = speech;
		this.speakerImage.gameObject.SetActive (false);
		this.response1.gameObject.SetActive (true);
		this.response2.gameObject.SetActive (true);
		this.response3.gameObject.SetActive (true);



	}

	// A string, an image and three possible responses
	public void Choice( string speech, Sprite speakerImage, UnityAction response1Event, UnityAction response2Event, UnityAction response3Event) {
		modalPanelObject.SetActive (true);

		response1.onClick.RemoveAllListeners ();
		response1.onClick.AddListener (response1Event);
		response1.onClick.AddListener (ClosePanel);

		response2.onClick.RemoveAllListeners ();
		response2.onClick.AddListener (response2Event);
		response2.onClick.AddListener (ClosePanel);

		response3.onClick.RemoveAllListeners ();
		response3.onClick.AddListener (response3Event);
		response3.onClick.AddListener (ClosePanel);

		this.speakerSpeech.text = speech;
		this.speakerImage.sprite = speakerImage;

		this.speakerImage.gameObject.SetActive (true);
		this.response1.gameObject.SetActive (true);
		this.response2.gameObject.SetActive (true);
		this.response3.gameObject.SetActive (true);



	}


	void ClosePanel() {
		
		modalPanelObject.SetActive (false);
	}
}
