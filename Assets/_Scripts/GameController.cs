using UnityEngine;
using System.Collections;

//reference to the UI namespcae
using UnityEngine.UI;

//Reference to manage my scenes
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
	//PRIVATE INSTANCE VARIABKES +++++++++++++++++++
	private int _livesValue;
	private int _scoreValue;
	private AudioSource _endGameSound;


	//PUBLIC INSTANCE VARIABLES (TESTING) ++++++++++
	public int zombieNumber = 3;
	public GameObject zombie;


	[Header("UI Objects")]
	public Text LivesLabel;
	public Text ScoreLabel;
	public Text GameOverLabel;
	public Text FinalScoreLabel;
	public Button RestartButton;


	[Header ("Game Objects")]
	public GameObject lucain;
	public GameObject island; //


	//PPUBLIC PROPERTIES +++++++++++++++++++++++++++
	public int LivesValue
	{
		get
		{
			return this._livesValue;
		}
		set
		{
			this._livesValue = value;
			if (this._livesValue <= 0) {
				this._endGame ();
			} 
			else 
			{
				this.LivesLabel.text = "Lives: " + this._livesValue;
			}
		}
	}

	public int ScoreValue
	{
		get
		{
			return this._scoreValue;
		}
		set
		{
			this._scoreValue = value;
			this.ScoreLabel.text = "Score: " + this._scoreValue;
		}
	}


	// Use this for initialization
	void Start () {
		this.LivesValue = 5;
		this.ScoreValue = 0;

		//hide the gameover text
		this.GameOverLabel.gameObject.SetActive (false);
		this.FinalScoreLabel.gameObject.SetActive (false);

		this.RestartButton.gameObject.SetActive (false);

		this._endGameSound = this.GetComponent<AudioSource> ();


		for (int zombieCount = 0; zombieCount < this.zombieNumber; zombieCount++) {
			Instantiate (this.zombie);

		}
	}
	
	// Update is called once per frame
	void Update () 
	{
	}


	private void _endGame()
	{
		this.GameOverLabel.gameObject.SetActive (true);
		this.FinalScoreLabel.text = "Final Score: " + this.ScoreValue;
		this.FinalScoreLabel.gameObject.SetActive (true);
		this.RestartButton.gameObject.SetActive (true);


		this.ScoreLabel.gameObject.SetActive (false);
		this.LivesLabel.gameObject.SetActive (false);

		this.lucain.SetActive (false);
		this.island.SetActive (false);

		this._endGameSound.Play ();
	}


	//PUBLIC METHODS ++++++++++++++++++++++++++++++++++++
	public void RestartButton_Click()
	{
		SceneManager.LoadScene ("Game");
	}
}
