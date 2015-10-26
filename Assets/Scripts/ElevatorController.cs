using UnityEngine;
using System.Collections;

public class ElevatorController : customBehaviour {
	public float speed;
	public float maxHeight;
	public float minHeight;
	public Rigidbody rb;
	public bool activated;
	// Use this for initialization
	private Vector3 current;
	void Start () {
		activated = false;
		rb = GetComponent<Rigidbody> ();
		current = transform.position;
		current.y = maxHeight;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (activated) {
			if (transform.position.y <= minHeight) {
				current.y = maxHeight;

			} else if (transform.position.y >= maxHeight) {
				current.y = minHeight;
			}
			transform.position = Vector3.MoveTowards (transform.position, current, speed * Time.deltaTime);
		}
	}
}
