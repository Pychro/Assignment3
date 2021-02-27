using UnityEngine;
using UnityEngine.SceneManagement;

public class Goalscript : MonoBehaviour {

	void OnTriggerEnter2D ()
	{
		Debug.Log("YOU WON!");
		Score.CurrentScore += 100;
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		
	}

}
