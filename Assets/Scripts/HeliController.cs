using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HeliController : MonoBehaviour {
	
	public GameObject horna_vrtula;
	public GameObject dolna_vrtula;
	public float EngineForce;
	private Rigidbody rb;
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
		RychlostVrtul = 1000f;
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow)) {
			rb.AddForce (Vector3.up * EngineForce, ForceMode.Force);
	
		}
	}
}
