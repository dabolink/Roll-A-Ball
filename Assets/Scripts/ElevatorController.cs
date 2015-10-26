using UnityEngine;
using System.Collections;

public class ElevatorController : ActivatibleController {
	public float speed;
	public float maxHeight;
	public float minHeight;
	public Rigidbody rb;

	// Use this for initialization
	private Vector3 current;
	void Start () {
		activated = false;
		rb = GetComponent<Rigidbody> ();
		current = transform.position;
		current.y = maxHeight;
	}

	protected override void while_active(){
		if (transform.position.y <= minHeight) {
			current.y = maxHeight;
			
		} else if (transform.position.y >= maxHeight) {
			current.y = minHeight;
		}
		transform.position = Vector3.MoveTowards (transform.position, current, speed * Time.deltaTime);
	}
}
