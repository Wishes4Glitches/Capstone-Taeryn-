using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour {

	// Use this for initialization
	void OnCollisionEnter(Collision col) {
		if (col.gameObject.tag == "Person")
        {
            Destroy(col.gameObject);
        }
	}
}
