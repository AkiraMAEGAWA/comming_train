using UnityEngine;
using System.Collections;

public class ChangeDirection : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("up")) {
			transform.position += transform.forward * 0.01f;
		}
		if (Input.GetKey ("right")){
			transform.Rotate (0, 1, 0);
	    }
        if (Input.GetKey ("left")){ 
    		transform.Rotate (0, -1, 0);
        }
	}
}
