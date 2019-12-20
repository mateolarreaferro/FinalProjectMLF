using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneBackLobby : MonoBehaviour
//Takes you back to the Lobby
{
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}
	// Changes Scene when player collides with game object
	void OnCollisionEnter(Collision gameObjectInformation)
	{
		if (gameObjectInformation.gameObject.name == "FPSController")
		{
			Debug.Log("Collision Detected");
			SceneManager.LoadScene("Lobby");
		}
	}

}
