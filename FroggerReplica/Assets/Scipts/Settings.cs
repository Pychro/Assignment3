using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    public InputField playername;
    public Dropdown lives;
    public Slider myslider;
    public GameObject car;
    public Button button;
    public Text speedValue;
    public Text topName;
    private bool isPaused = false;
    public Text buttontext;

    void Start(){
        float speed = PlayerPrefs.GetFloat("speed");
        GetComponent<Car>().speed += speed;
        Button btn = button.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
        
    }

    void FixedUpdate(){
        topName.text = PlayerPrefs.GetString("playername");
    }

    public void playerName(){
        PlayerPrefs.SetString("playername", playername.text);
        PlayerPrefs.Save();
    }

    public void liveSelector(){
        PlayerPrefs.SetInt("playerLives", lives.value);
        PlayerPrefs.Save();
    }

    public void carSpeed(){
        PlayerPrefs.SetFloat("speed", myslider.value);
        PlayerPrefs.Save();
    }

    public void TaskOnClick(){
        
        SceneManager.LoadScene("Frogger");
    }

    public void changeSpeedValue(){
        speedValue.text = myslider.value.ToString();
    }

    public void pauseGame(){
        if(isPaused == false){
            Time.timeScale = 0f;
            isPaused = true;
            buttontext.text = "Resume";
        }
        else if(isPaused == true){
            Time.timeScale = 1f;
            isPaused = false;
            buttontext.text = "Pause";
        }
    }


    
}
