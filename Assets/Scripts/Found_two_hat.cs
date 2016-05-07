using UnityEngine;
using System.Collections;
using Vuforia;
using System.Collections.Generic;

public class Found_two_hat : MonoBehaviour
{

	//public GameObject cageWings;
	//private Animator animator;
	public GameObject mChainmail_hat;
	//public GameObject remainsPieces;

	// set a bool for the hat state - instantiated_hat is true means all the rotations stop
	public bool instantiated_hat = false;
	private ItemRotator[] myIMS;
	private ItemRotatorStill[] myIMS2;
	
	// Use this for initialization
	void Start ()
	{
		//animator = cageWings.GetComponent<Animator>() as Animator;
		Debug.Log ("testingStart");
		//animator.Play("FancyArmature|Action");
		//animator.SetBool ("found2", false);
		//mChainmail_hat = transform.FindChild ("chainmail_hat3").gameObject;

	
	}
	
	// Update is called once per frame
	void Update ()
	{
		myIMS = FindObjectsOfType<ItemRotator> ();
		if (DefaultTrackableEventHandler.carolineFound
			&& DefaultTrackableEventHandler.cattFound) {
			Debug.Log ("I found both hat and cat");
			if (!instantiated_hat) {
				Debug.Log ("found child");
				foreach (ItemRotator im in myIMS ) {
					im.enabled = false;
					instantiated_hat = true;
				}
				foreach (ItemRotatorStill im2 in myIMS2 ) {
					im2.enabled = false;
					//instantiated_hat = true;
				}
			}
			//cageWings = transform.FindChild("cageWings").gameObject;

			//animator.SetBool("Found2", true);

			//animator.SetTrigger("found2");
		} else {
			instantiated_hat = false;
			foreach (ItemRotator im in myIMS) {
				im.enabled = true;
			}

		}
	}


}
