using UnityEngine;
using System.Collections;

public class SwitchcolorAtEnd : MonoBehaviour {

	public Color[] colors = new Color[6];
	public bool go;

    void Start() {

    }

    void Update(){
    	if (go)
    	gameObject.GetComponent<Renderer>().material.color = colors[Random.Range(0, colors.Length)];
    }

}