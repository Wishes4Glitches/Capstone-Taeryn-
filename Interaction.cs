using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interaction : MonoBehaviour {

	// Use this for initialization
	void OnCollisionEnter(Collision col) {
		if (col.gameObject.tag == "Person")
        {
			//destroy the object with the tag "Person"
            Destroy(col.gameObject);
			SceneManager.LoadScene(1, LoadSceneMode.Additive);
		}
	}
}
