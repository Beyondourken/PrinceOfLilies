using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {
	void OnTriggerEnter(Collider col) {
		if(col.CompareTag("Player")) {
			SceneManager.LoadScene ("02 Garden");
		}
	}
}
