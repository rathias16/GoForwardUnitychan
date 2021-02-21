using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour {

    private GameObject gameOver;

    private GameObject runLengthText;

	private GameObject panel;
	private GameObject howToPanel;

    private float len = 0;

    private float speed = 0.03f;

    private bool isGameOver = false;

	public bool isStarted = false;

	// Use this for initialization
	void Start () {
        this.gameOver = GameObject.Find("GameOver");
		gameOver.SetActive(false);
        this.runLengthText = GameObject.Find("RunLength");
		this.runLengthText.SetActive(false);
		this.panel = GameObject.Find("Panel");
		this.howToPanel = GameObject.Find("HowToPanel");
		howToPanel.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if (this.isGameOver == false)
		{
			if (isStarted)
			{
				this.len += this.speed;

				this.runLengthText.GetComponent<Text>().text = "Distance:  " + len.ToString("F2") + "m";
			}
		}
		else
		{
			if (Input.GetMouseButtonDown(0))
			{
				SceneManager.LoadScene("GameScene");
			}
		}
		
	}
    public void GameOver()
    {
		gameOver.SetActive(true);

        this.isGameOver = true;
    }

	public void PushStartButton() {
		panel.SetActive(false);
		isStarted = true;
		runLengthText.SetActive(true);
	}

	public void PushBackButton() {
		panel.SetActive(true);
		howToPanel.SetActive(false);
	}
	public void PushHowToButton() {
		panel.SetActive(false);
		howToPanel.SetActive(true);
	}
}
