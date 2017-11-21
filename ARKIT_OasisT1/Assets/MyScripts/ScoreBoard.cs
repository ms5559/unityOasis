using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBoard : MonoBehaviour {

	public int counter;

	public TextMesh points;

	public AudioClip impact;
    AudioSource audio;
	// Use this for initialization
	void Start () {

		audio = GetComponent<AudioSource>();
		
	}
	
	// Update is called once per frame
	void Update () {

		points.text = "" + counter;
		
	}

	void OnTriggerEnter(Collider other){
		
		counter++;
		audio.PlayOneShot(impact, 1.0F);

	}

}
