using UnityEngine;
using System.Collections;

public class CubeEnemyAi : MonoBehaviour {

	void Start(){
	}
	void Update () {
		move('x');  
		
	}
	void move(char c) {
		Vector3 point = transform.position;
		Vector3 axis = Vector3.back;
		float angle = 100f * Time.deltaTime;
		transform.RotateAround (point, axis, angle);
		transform.position = transform.position + new Vector3(Time.deltaTime,0,0);
	}
}
