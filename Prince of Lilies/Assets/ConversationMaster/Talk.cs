using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Talk {

	// creates conversation database

	public int talkID;
	public Sprite talkSpeaker;
	public string talkSpeech;
	public string talkResponse;
	public int talkNextID;
	public bool isImmediate;
	public string talkResponse1;
	public int talkNextID1;
	public bool isImmediate1;
	public string talkResponse2;
	public int talkNextID2;
	public bool isImmediate2;
	//public List<string> talkResponse;
	//public List<int> talkNextID;


	//public Talk (int id, string speaker, string speech, List<string> response, List<int> nextID)
	public Talk(int id, string speaker, string speech, string response, int nextID, bool now,  string response1, int nextID1, bool now1, string response2, int nextID2, bool now2)
    {
		talkID = id;
		talkSpeaker = Resources.Load<Sprite>("" + speaker);
		talkSpeech = speech;
		talkResponse = response;
		talkNextID = nextID;
		isImmediate = now;
		talkResponse1 = response1;
		talkNextID1 = nextID1;
		isImmediate1 = now1;
		talkResponse2 = response2;
		talkNextID2 = nextID2;
		isImmediate2 = now2;
	//	foreach(string res in response) {
//			talkResponse.Add(res);
			//talkNextID[i] = nextID[i];
//	}

    }

    public Talk() {
	}
}
