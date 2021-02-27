
using UnityEngine;
using UnityEngine.SceneManagement;

public class Frog : MonoBehaviour {

	public Rigidbody2D rb;
	public Transform transform;
	public int lives;
	int dead = 0;
	private Vector3 resetPosition;

	void Start(){
		resetPosition = transform.position;
		lives = PlayerPrefs.GetInt("playerLives");
	}

	void Update () {

		if (Input.GetKeyDown(KeyCode.RightArrow))
			rb.MovePosition(rb.position + Vector2.right);
		else if (Input.GetKeyDown(KeyCode.LeftArrow))
			rb.MovePosition(rb.position + Vector2.left);
		else if (Input.GetKeyDown(KeyCode.UpArrow))
			rb.MovePosition(rb.position + Vector2.up);
		else if (Input.GetKeyDown(KeyCode.DownArrow))
			rb.MovePosition(rb.position + Vector2.down);

	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "Car")
		{
			if(lives > dead){
			transform.position = resetPosition;
			lives--;
			}
			else if (lives <= dead){
				SceneManager.LoadScene(2);
			}

		}
		
	}
}
