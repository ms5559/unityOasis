using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collided : MonoBehaviour {

	public GameObject counter;
	public bool hitOnce = true;


	// Use this for initialization
	void Start () {

		counter = GameObject.FindWithTag("Counter");
		counter.GetComponent<ColliderCounter>().colliderAmount++;

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(){

		if (hitOnce){
		counter.GetComponent<ColliderCounter>().counter++;
		hitOnce = false;


		}	

	}

}
