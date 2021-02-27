
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class livesText : MonoBehaviour
{
    
    public GameObject frog;
	public Text lives;

	void FixedUpdate ()
	{
		lives.text = frog.GetComponent<Frog>().lives.ToString() + " Lives Left";
	}
}
