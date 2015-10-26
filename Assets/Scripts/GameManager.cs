using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {

	public int score;
	public int max_score;
	public int lives;
	public float speed;
	public Text livesText;
	public Text scoreText;
	public Text winText;

	void Start(){
		score = 0;
		max_score = 12;
		speed = 10;
		lives = 5;
		livesText.text = "Lives: " + lives;
		scoreText.text = "Count: " + score.ToString () + "/" + max_score.ToString();
		winText.text = "";
	}
	
	public void setLives()
	{
		lives--;
		livesText.text = "Lives: " + lives.ToString ();
		if (lives <= 0){
			winText.text = "GAME OVER";
		}
	}
	public void setScore()
	{
		score++;
		scoreText.text = "Count: " + score.ToString () + "/" + max_score.ToString();
		if (score >= max_score) {
			winText.text = "You Win!";
		}
	}
}
