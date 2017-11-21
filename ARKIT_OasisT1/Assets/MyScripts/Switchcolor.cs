using UnityEngine;
using System.Collections;

public class Switchcolor : MonoBehaviour {

	public Color[] colors = new Color[6];

    void Start() {

    }

    void Update(){
    	gameObject.GetComponent<Renderer>().material.color = colors[Random.Range(0, colors.Length)];
    }

}