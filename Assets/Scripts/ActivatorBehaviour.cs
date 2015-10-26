using UnityEngine;
using System.Collections;

public class ActivatorBehaviour : MonoBehaviour{

	public GameObject activatible;
	public bool activated;

	protected ActivatibleController activatibleScript;

	void OnTriggerEnter(Collider other){
		if(other.CompareTag("Player")){
			activatibleScript.activated = true;
			when_triggered ();
		}
	}
	protected virtual void when_triggered(){
		Debug.Log ("When Triggered not done");
	}
}

