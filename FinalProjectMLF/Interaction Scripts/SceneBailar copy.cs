using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneBailar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision gameObjectInformation)
    	// Changes Scene when player collides with game object

    {
        if (gameObjectInformation.gameObject.name == "FPSController")
        {
            Debug.Log("Collision Detected");
            print("Dale Mateo, Dale!");
            SceneManager.LoadScene("Maread@");
        }
    }

}
