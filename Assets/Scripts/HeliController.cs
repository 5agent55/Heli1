using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HeliController : MonoBehaviour {
	
	public GameObject horna_vrtula;
	public GameObject dolna_vrtula;
	public float RychlostVrtul
	{
		get{
			return horna_vrtula.GetComponent<rotator> ().Amplituda;
		}
		set{
			horna_vrtula.GetComponent<rotator> ().Amplituda = value; 
			dolna_vrtula.GetComponent<rotator> ().Amplituda = -value;
		}
	}	


	// Use this for initialization
	void Start () {
		RychlostVrtul = 500f;


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
