using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColliderCounter : MonoBehaviour {

	public int counter;
	public int colliderAmount;
	public TextMesh statusText;
	public float delayBeforeNextLevel = 2.0f;
	public GameObject letterPlane;

	private IEnumerator coroutine;


	// Use this for initialization
	void Start () {

		letterPlane = GameObject.FindWithTag("letterPlane");
		
	}
	
	// Update is called once per frame
	void Update () {

		if (counter >= colliderAmount){
			statusText.text = "YES!";
			letterPlane.GetComponent<SwitchcolorAtEnd>().go = true;

			coroutine = WaitAndGo(delayBeforeNextLevel);
			StartCoroutine(coroutine);
		}

	}

	private IEnumerator WaitAndGo(float waitTime){

		while (true)
        {
            yield return new WaitForSeconds(waitTime);
           	
           	if (SceneManager.GetActiveScene().name == "Level_A"){
         	SceneManager.LoadScene("Level_B");
     		}

     		if (SceneManager.GetActiveScene().name == "Level_B"){
         	SceneManager.LoadScene("Level_C");
     		}

     		if (SceneManager.GetActiveScene().name == "Level_C"){
         	SceneManager.LoadScene("Level_D");
     		}

     		if (SceneManager.GetActiveScene().name == "Level_D"){
         	SceneManager.LoadScene("Level_E");
     		}

     		if (SceneManager.GetActiveScene().name == "Level_E"){
         	SceneManager.LoadScene("Level_A");
     		}
        }

	}
}
