using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mainGame : MonoBehaviour {

	float seconds;
	float minutes;
	float hours;
	float totalTime;
	string displayTime;

	public Text Timer;
	bool buttonPressed;

	public GameObject losePanel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(buttonPressed == true){
			seconds += Time.deltaTime;
			if(seconds >= 60){
				seconds = 0;
				minutes += 1;

				if(minutes >= 60){
					hours += 1;
				}
			}
			Timer.text = hours.ToString("00")+":"+minutes.ToString("00")+":"+seconds.ToString("00");
			totalTime = hours+minutes+seconds;

			if(totalTime > PlayerPrefs.GetFloat("highScore")){
				PlayerPrefs.SetFloat("highScore",totalTime);

				PlayerPrefs.SetString("highScoreText","HIGH SCORE "+hours.ToString("00")+":"+minutes.ToString("00")+":"+seconds.ToString("00"));
			}
		}
	}

	public void buttonPress(){
		buttonPressed = true;
	}
	public void buttonRelease(){
		buttonPressed = false;
		losePanel.SetActive(true);
	}

	public void tryAgain(){
		SceneManager.LoadScene("mainscreen");
	}
}
