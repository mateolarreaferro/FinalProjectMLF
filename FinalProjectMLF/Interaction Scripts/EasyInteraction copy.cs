using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyInteraction : MonoBehaviour
{
    
    public GameObject targetObject;

    public string tagName;
// Interaction options
    public bool changeColor;
    public Color targetColor;
    public bool makeSound;
    public AudioClip sound;
    public bool switchEnabling;
    public bool destroyObject;
//To this object
    public GameObject changedObject;
    
    void Start()
    {
        //Error messages
       
        if (changeColor && targetColor == null)
        {
            Debug.Log("Select Color");
        }
        if(changedObject == null)
        {
            Debug.Log("Object to be changed is missing");
        }

        //Check if either objects have rigidboddies and colliders
        if (gameObject.GetComponent<Rigidbody>() == null)
        {
            gameObject.AddComponent<Rigidbody>();
            gameObject.GetComponent<Rigidbody>().useGravity = false;
            gameObject.GetComponent<Rigidbody>().isKinematic = true;
        }
        if(gameObject.GetComponent<Collider>() == null)
        {
            gameObject.AddComponent<MeshCollider>();
        }

        if (targetObject != null)
        {
            if (targetObject.GetComponent<Rigidbody>() == null)
            {
                targetObject.AddComponent<Rigidbody>();
                targetObject.GetComponent<Rigidbody>().useGravity = false;
                targetObject.GetComponent<Rigidbody>().isKinematic = true;
            }
            if (targetObject.GetComponent<Collider>() == null)
            {
                targetObject.AddComponent<MeshCollider>();
            }
        }

        //Assigns audio to object
        if(makeSound && changedObject.GetComponent<AudioSource>() == null)
        {
            changedObject.AddComponent<AudioSource>();
            changedObject.GetComponent<AudioSource>().playOnAwake = false;
            changedObject.GetComponent<AudioSource>().clip = sound;
        }

  

        //Turn ON is trigger to object 1
        gameObject.GetComponent<Collider>().isTrigger = true;
    }

    //Execute the actions when target object name or tag enters this collider
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == tagName)
        {
            ExecuteAction();
        }
        if(targetObject != null && other.name == targetObject.name)
        {
            ExecuteAction();
        }
    }

    public void ExecuteAction()
    {
        //Change color
        if (changeColor)
        {
            changedObject.GetComponent<Renderer>().material.color = targetColor;
        }
        
        if (makeSound)
        {
            changedObject.GetComponent<AudioSource>().Play();
        }
        //Destroy object
        if (destroyObject)
        {
            Destroy(changedObject);
        }
    }
}
