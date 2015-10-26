using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public int score;
	public int lives;
	public float speed;

	void Start(){
		score = 0;
		speed = 10;
		lives = 5;
	}
}
