using UnityEngine;
using System.Collections;

public class Drawing : MonoBehaviour {

	public Transform cursorIndicator;
	public GameObject prefab1;
	
	public float minScale;
	public float maxScale;
	
	public GUIText label;
	private float labelTimer=-1;
	
	void Start(){
	}

		//called when the touch or a click is detected!!!!!!!!!!!!
	void OnOn(Vector2 pos){
		//place the curose at the position where the tap/click take place
		Vector3 p=Camera.main.ScreenToWorldPoint(new Vector3(pos.x, pos.y, 5));
		cursorIndicator.position=p;
		label.text="position: "+ cursorIndicator.position.ToString("f1")+"\n";
		Instantiate(prefab1, p, Random.rotation);
		prefab1.transform.localScale = Vector3.one * Random.Range(minScale, maxScale);
		//prefab1.transform.rotation = 

	}
	
	void OnEnable(){
		IT_Gesture.onTouchPosE += OnOn;
		IT_Gesture.onMouse1E += OnOn;
	}
	
	void OnDisable(){
		IT_Gesture.onTouchPosE -= OnOn;
		IT_Gesture.onMouse1E -= OnOn;
	}
	
	
	
	//clear the lable, if no new input has been assigned within 5 sec, the label will be cleared
	IEnumerator ClearLabel(){
		labelTimer=5;
		while(labelTimer>0){
			labelTimer-=Time.deltaTime;
			yield return null;
		}
		label.text="";
	}
	
	
	

}

