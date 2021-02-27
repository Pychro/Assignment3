using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public Button startOver;
    public Button quit;
    public Text endGame;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = startOver.GetComponent<Button>();
		btn.onClick.AddListener(startGameOver);
        Button btn2 = quit.GetComponent<Button>();
		btn2.onClick.AddListener(quitGame);
        
    }

    void FixedUpdate(){
        endGame.text = "Congratulations " + PlayerPrefs.GetString("playername") + ", your score was " + PlayerPrefs.GetInt("score").ToString() + " points!";
    }

    void startGameOver(){
        SceneManager.LoadScene("Menu");
    }

    void quitGame(){
        Application.Quit();
    }

}
