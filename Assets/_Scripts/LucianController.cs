﻿using UnityEngine;
using System.Collections;

public class LucianController : MonoBehaviour {

	//PRIVATE INSTANCE VARIABLES
	private Transform _transform;


	//PUBLIC INSTANCE VARIABLES(TESTING ONLY)
	public GameController gameController;


	[Header("Sounds")]
	public AudioSource thunderSound;
	public AudioSource yaySound;



	// Use this for initialization
	void Start () {
		this._transform = this.GetComponent<Transform> ();
		}
	
	// Update is called once per frame
	void Update () {
		this._move ();
	}
		
	//This moethod moves the game object across the x-axis following the mouse movement
	private void _move()
	{
		this._transform.position = new Vector2 (Mathf.Clamp(Input.mousePosition.x - 320f,-283f, 283f), - 150f);
	}

	//This method checks if the 
	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag ("Island")) 
		{
			Debug.Log ("Island Hit!!!");
			this.yaySound.Play ();
			this.gameController.ScoreValue += 100;

		}

		if (other.gameObject.CompareTag ("Zombie")) 
		{
			
			Debug.Log ("Zombie Hit!!!");
			this.thunderSound.Play ();
			this.gameController.LivesValue -= 1;
		}
	}

}
