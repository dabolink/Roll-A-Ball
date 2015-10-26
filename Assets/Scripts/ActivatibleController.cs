using UnityEngine;
using System.Collections;

public class ActivatibleController : MonoBehaviour
{
	public bool activated = false;
	void FixedUpdate(){
		if (activated) {
			while_active();
		}
	}

	protected virtual void while_active ()
	{
		Debug.Log ("While Active not found");
	}
}


