using UnityEngine;
using System.Collections;

public class ItemRotatorScale : MonoBehaviour
{
	public float min = 0.035f;
	public float max = 0.12f;
	public bool enableRotation = true;
	//Transform[] allChildren;

	// Use this for initialization
	void Start ()
	{
		//allChildren = GetComponentsInChildren<Transform> ();
	}


	// Update is called once per frame
	void Update ()
	{
		if (enableRotation = true) {
			//foreach (Transform t in allChildren) {
//				Debug.Log ("found the child");
//				 time.deltatime changes the change from framrate to time
				
				//transform.Rotate (new Vector3 (0, 0, 20) * Time.deltaTime);
				//t.localRotation = Quaternion.Euler (0, 0, Random.Range (0, 360f) * Time.deltaTime);
				float randomVec3 = Random.Range (min, max);
				transform.localScale = Vector3.Scale (new Vector3 (1, 1, 1), new Vector3 (randomVec3, randomVec3, randomVec3));
			//}
		}
	}

	// void fixedUpdate () {} is a function that uses time
}
