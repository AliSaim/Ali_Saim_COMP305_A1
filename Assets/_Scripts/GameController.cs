using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	//PRIVATE INSTANCE VARIABKES +++++++++++++++++++


	//PUBLIC INSTANCE VARIABLES (TESTING) ++++++++++
	public int zombieNumber = 3;
	public GameObject zombie;

	//PPUBLIC PROPERTIES +++++++++++++++++++++++++++


	// Use this for initialization
	void Start () {
	
		for (int zombieCount = 0; zombieCount < this.zombieNumber; zombieCount++) {
			Instantiate (this.zombie.gameObject);

		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
