using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class deszhuan : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{

		if (gameObject.transform.position.y <= -2) 
		{
		
			xmshauliang = ++GameObject.Find("MianCamera").transform.GetComponent<sheji>().xmcount;

			sdshuliang = GameObject.Find("MianCamera").transform.GetComponent<sheji>().sjcount;
			GameObject.Find("wenzi").transform.GetComponent<Text>().text = "射弹数: " + sdshuliang + "  消灭数: " + xmshauliang;
			
			if (xmshauliang >= 3) 
			{
				GameObject.Find("wenzi").transform.GetComponent<Text>().text = "恭喜过关" ; 
				GameObject.Find("MianCamera").transform.GetComponent<sheji>().enabled = false;
			}
			Destroy(gameObject);
		}


	}

	private int sdshuliang;

	private int xmshauliang;
}
