using UnityEngine;
using System.Collections;

public class ButtonController : ActivatorBehaviour {
	public Material active_material;
	// Use this for initialization
	void Start () {
		activated = false;
		activatibleScript = activatible.GetComponent<ElevatorController>();
	}

	protected override void when_triggered(){
		MeshRenderer renderer = GetComponent<MeshRenderer> ();
		renderer.material = active_material;
		this.transform.localScale = new Vector3(this.transform.localScale.x, this.transform.localScale.y/2, this.transform.localScale.z);
	}
}
