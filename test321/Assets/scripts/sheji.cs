using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class sheji : MonoBehaviour {

	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {

		x = Input.GetAxis ("Horizontal") * Time.deltaTime * speed;

		z = Input.GetAxis ("Vertical") * Time.deltaTime * speed;

		//
		gameObject.transform.Translate (x, 0, z);




		if (Input.GetButtonDown ("Fire1")) 
		 {
		    GameObject b = Instantiate (a, transform.position, transform.rotation) as GameObject;

			Vector3 fx = transform.TransformDirection(Vector3.forward);

			b.transform.rigidbody.AddForce(fx*2800);

			sjcount = sjcount + 1;

		  }
		if (Input.GetKey (KeyCode.Q)) 
	     {
			transform.Rotate(0,-35*Time.deltaTime,0,Space.Self);
		 }
		if (Input.GetKey (KeyCode.E))
		 {
			transform.Rotate(0,35*Time.deltaTime,0,Space.Self);
		 }

		if (Input.GetKey (KeyCode.Z)) 
		{
			transform.Rotate(-25*Time.deltaTime,0,0,Space.Self);
		}
		if (Input.GetKey (KeyCode.C))
		{
			transform.Rotate(25*Time.deltaTime,0,0,Space.Self);
		}

		if (Input.GetKey (KeyCode.H)) 
		{
			transform.Translate(0,5*Time.deltaTime,0);
		}
		if (Input.GetKey (KeyCode.N)) 
		{
			transform.Translate(0,-5*Time.deltaTime,0);
		}

	
	}
	private int speed = 5;
	private float x = 0.0f;
	private float z = 0.0f;

	public int sjcount = 0;

	public int xmcount = 0;

	public GameObject a;
	

}
