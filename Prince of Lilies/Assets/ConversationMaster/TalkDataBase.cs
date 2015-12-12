using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TalkDataBase : MonoBehaviour {

	public List<Talk> talkList = new List<Talk>();
    // Use this for initialization
 //  List<string> response = new List<string>();
//	List<int> nextID = new List<int> ();

	void Start () {
		//response.Add("OK");
	//	nextID.Add(0);
		//talkList.Add (new Talk (101,"Guard", "You can not enter here", response, nextID ));
        talkList.Add(new Talk(101, "Guard", "You can not enter here","OK", 0, "Understood", 0, "Sorry", 0));
        /*	response.Clear();
            response.Add("Sorry");
            response.Add("I won't do it again");
            //int[] input = new int[] { 2,2};
            //nextID.InsertRange (0,input);
            nextID.Clear();
            nextID.Add (2);
            nextID.Add(2);
            talkList.Add (new Talk (102,"Guard", "This bell is for emergencies only", response, nextID ));
            response [0] = "Very Sorry";
            response[1] = "This is an emergency";
            nextID[0]  = 3;
            nextID [1] = 3;
            talkList.Add (new Talk (103,"Guard", "If you ring that again I will throw you in the dungeons",response, nextID  ));
            response [0] = "Help!";
            response[1] = "Oh no! Not the dungeons.";
            nextID[0]  = 0;
            nextID [1] = 0;

            talkList.Add (new Talk (104,"Guard", "That's it. To the dungeons with you", response, nextID  ));
    */
    }
	


}
