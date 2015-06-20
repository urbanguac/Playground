using UnityEngine;
using System.Collections;

public class ExplodeOnImpact : MonoBehaviour {
	public NetworkView networkView;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	[RPC]
	public static void ExplodeObject(GameObject x){
		x.SendMessage ("Explode"); Destroy (x);
	}
	
	void OnTriggerEnter(Collider other)
	{
		Debug.Log ("Collided");
		if (other.gameObject.tag == "Weapon") 
		{
			gameObject.SendMessage("Explode");
//			NetworkView networkView = new NetworkView();
//			networkView.RPC ("ExplodeObject",RPCMode.All,gameObject);
			Destroy(gameObject);
			Debug.Log ("Explode message sent.");
		}

	}
}
