using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Vuforia;

public class spaceBarDest : MonoBehaviour {
	private GameObject mChainmail;
	public GameObject remainsPieces;

	// Use this for initialization
	void Start () {
		mChainmail = transform.FindChild("chainmail").gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			Instantiate (remainsPieces, transform.position, transform.rotation); 
			//Destroy(mChainmail);
			mChainmail.SetActive (false);
			StartCoroutine (Chainmail ());
		}
	}
	
	IEnumerator Chainmail() {
			yield return new WaitForSeconds(5);
			mChainmail.SetActive(true);
		}
}
