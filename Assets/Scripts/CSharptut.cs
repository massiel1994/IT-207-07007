﻿using UnityEngine;
using System.Collections;
using System;
public class CSharptut : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Variables myClass;
		myClass = new Variables ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

public class Variables
{
	public void Test()
	{
				int x = 100;
				int y;
				y = 150;

				int z; is le

				z = x + y;

				Debug.Log( String.Format( "{0}", z) );
			
		string Name = "Joe";
		string Surname = "Schmoe";

		Debug.Log(Name + " " + Surname);
		Debug.Log (String.Concat (Name, " ", Surname));
		if (/"condition"/ )
			( /" true part "/}
			 Debug.Log("Z is less than 200");
			 else{ /" false part "/}
			{ /* false part */
				Debug.Log(" Z is greater than 200");
			}
			Debug.Log(z >= 150) ? "Z is greater than 150" : " Z is less than 150");
		}
	}