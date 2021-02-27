using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Border : MonoBehaviour
{
    void OnTriggerEnter2D (Collider2D col)
	{
        if(col.tag != "Car"){
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if(col.tag == "Car"){
            Destroy(this);
        }
		
	}
}
