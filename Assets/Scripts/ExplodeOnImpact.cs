using UnityEngine;
using System.Collections;

public class ExplodeOnImpact : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		Debug.Log ("Collided");
		if (other.gameObject.tag == "Weapon") 
		{
			gameObject.SendMessage("Explode");
			Destroy(gameObject);
			Debug.Log ("Explode message sent.");
		}

	}
}
