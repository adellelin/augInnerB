using UnityEngine;
using System.Collections;

public class ItemRotator : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// time.deltatime changes the change from framrate to time
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
	}

	// void fixedUpdate () {} is a function that uses time
}
