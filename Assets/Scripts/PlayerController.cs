using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float boundry = -5f;
	public GameObject GM;

	private GameManager GMScript;
    private Rigidbody rb;

    void Start()
    {
		GMScript = GM.GetComponent<GameManager>();
        rb = GetComponent<Rigidbody>();
		GMScript.setScore();
		GMScript.setLives ();
    }
    //called just before physics update
    void FixedUpdate()
    {
        float moveHorizonatal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizonatal, 0.0f, moveVertical);
		rb.AddForce(movement * GMScript.speed);
		if (rb.transform.position.y < boundry) {
			reset();
		}
    }
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Pick Up")) {
			other.gameObject.SetActive (false);
			GMScript.setScore();
		}
		if (other.gameObject.CompareTag ("Enemy")) {
			reset ();
		}
	}
	void reset(){
		rb.transform.position = new Vector3 (0f, 0.5f, 0f);
		rb.velocity = Vector3.zero;
		GMScript.setLives();
	}
}
