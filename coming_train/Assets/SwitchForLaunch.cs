using UnityEngine;
using System.Collections;

public class SwitchForStart : MonoBehaviour {
	public GameObject Train;

	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "Player") {
			Destroy (this.gameObject);
			PassAway train = Train.AddComponent<PassAway> ();
		}


	// Use this for initialization
	}

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
