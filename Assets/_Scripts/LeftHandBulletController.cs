using UnityEngine;
using System.Collections;

public class LeftHandBulletController : MonoBehaviour {

	private int _speed = 6;
	private Transform _transform;

	//PUBLIC PROPERTIES
	public int Speed {
		get
		{
			return this._speed;
		}
		set
		{
			this._speed = value;
		}
	}

	// Use this for initialization
	void Start () {
		this._transform = this.GetComponent<Transform> ();
		this._reset ();

	}

	// Update is called once per frame
	void Update () {
		this._move ();
		this._checkBounds ();
	}

	//This method moves the game object down the screen by _speed px every frame
	private void _move()
	{
		Vector2 newPosition = this._transform.position;
		newPosition.y += this._speed;
		this._transform.position = newPosition;
	}


	//This method checks to see if the game object meets the top border of the screen
	private void _checkBounds()
	{
		if (this._transform.position.y >= 270f) 
		{
			this._reset ();
		}
	}


	//This methods reset the game object to the orginal position
	private void _reset()
	{
		//this._speed = 6;
		this._transform.position = new Vector2 (Input.mousePosition.x -340f, -100);
	}
}
