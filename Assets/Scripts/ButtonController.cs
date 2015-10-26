using UnityEngine;
using System.Collections;

public class ButtonController : MonoBehaviour {
	public GameObject activatable;
	public bool activated;

	private ElevatorController activatableScript;
	// Use this for initialization
	void Start () {
		activated = false;
		activatableScript = activatable.GetComponent<ElevatorController>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Player") && !activated) {
			activated = true;
			this.transform.localScale = new Vector3(this.transform.localScale.x, this.transform.localScale.y/2, this.transform.localScale.z);
			activatableScript.activated = true;

		}
	}
}
