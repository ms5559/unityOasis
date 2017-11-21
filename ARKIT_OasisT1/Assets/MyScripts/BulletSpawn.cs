using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour {

	public  float timeDelay = 10.0f;
    private float timestamp;

    public bool iamHit;

    public Rigidbody bulletPrefab;
  
    void Start () 
    {
        timestamp = Time.time + timeDelay;
    }
  
    void Update() 
    {
        if(iamHit && timestamp < Time.time) {
           Fire();
           timestamp += timeDelay;
        }

        if (Input.GetKeyDown("r")){
        	iamHit = !iamHit;
        }
    }


	public void Fire () 
	{

			Rigidbody clone;
			clone = Instantiate(bulletPrefab, transform.position, transform.rotation) as Rigidbody;
			clone.velocity = transform.TransformDirection(Vector3.forward * 10);
			Destroy(clone,3);
			//yield WaitForSeconds(fireRate);
	}
}
