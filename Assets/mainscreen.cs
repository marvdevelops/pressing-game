using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mainscreen : MonoBehaviour {

	public Text highScoreDisplay;

	// Use this for initialization
	void Start () {
		highScoreDisplay.text = PlayerPrefs.GetString("highScoreText");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void startGame(){
		SceneManager.LoadScene("maingame");
	}
}
