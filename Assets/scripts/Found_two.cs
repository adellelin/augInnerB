using UnityEngine;
using System.Collections;
using Vuforia;
using System.Collections.Generic;

public class Found_two : MonoBehaviour {

	//public GameObject cageWings;
	//private Animator animator;
	private GameObject mChainmail;
	public GameObject remainsPieces;
	public bool instantiated = false;
	
	// Use this for initialization
	void Start () {
		//animator = cageWings.GetComponent<Animator>() as Animator;
		Debug.Log ("testingStart");
		//animator.Play("FancyArmature|Action");
		//animator.SetBool ("found2", false);
		mChainmail = transform.FindChild ("chainmail_mouth").gameObject;
			
	}
	
	// Update is called once per frame
	void Update () {
		if (DefaultTrackableEventHandler.carolineFound
			&& DefaultTrackableEventHandler.cattFound) {
			Debug.Log ("I found both");
			if (!instantiated) {
				Instantiate (remainsPieces, transform.position, transform.rotation); 
				//Destroy(mChainmail);
				mChainmail.SetActive (false);
				StartCoroutine (Chainmail ());
				instantiated = true;
			}
			//cageWings = transform.FindChild("cageWings").gameObject;

			//animator.SetBool("Found2", true);

			//animator.SetTrigger("found2");
		} else {
			instantiated = false;
		}
	}

	IEnumerator Chainmail() {
		yield return new WaitForSeconds(5);
		mChainmail.SetActive(true);
	}
}
