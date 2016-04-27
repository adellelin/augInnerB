using UnityEngine;
using System.Collections;

public class selfDestruct : MonoBehaviour {

	//private GameObject mChainmail;

	// Use this for initialization
	IEnumerator Start () {
		//mChainmail = transform.FindChild("chainmail").gameObject;
		yield return new WaitForSeconds(5);
		//Destroy (gameObject);
		gameObject.SetActive (false);
		GameObject.FindObjectOfType<Found_two> ().GetComponent<Found_two> ().instantiated = false;
	}
	

}
