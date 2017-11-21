using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCollider1 : MonoBehaviour {

	public BulletSpawn portal;

	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{

		
	}

	void OnMouseEnter()
	{

		if (Input.GetMouseButtonDown(0))
		{
			print("clicked!");
			portal.iamHit = true;
		}

		if (Input.GetMouseButtonUp(0))
		{
			portal.iamHit = false;
		}
	}
}
