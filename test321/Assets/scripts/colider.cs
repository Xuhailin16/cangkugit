using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class colider : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter()
	{
		GameObject.Find("wenzi").transform.GetComponent<Text>().text = "pengshangla";
	//	GameObject.Find ("Directional light").transform.GetComponent<Light> ().enabled = false;
		Destroy (gameObject);
	}

	void testcangku()
	{
		print ("hah");
	}
	//zhushi
}
