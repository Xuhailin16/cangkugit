﻿using UnityEngine;
using System.Collections;

public class uIButtonClick : MonoBehaviour {


	public  void QuitButtonClick()
	{ 
		Application.Quit ();
	}

	public   void StartButtonClick()
	{ 
		Application.LoadLevel ("Untitled");
	}
	
	public void testcangku()
	{
		print("Yes");
	}


}
