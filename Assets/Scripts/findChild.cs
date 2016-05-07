using UnityEngine;
using System.Collections;

public class findChild : MonoBehaviour
{
	public bool enableRotation = true;
	Transform[] allChildren;
	public ItemRotator scriptEnable;
	// Use this for initialization
	void Start ()
	{
		allChildren = GetComponentsInChildren<Transform> ();
		scriptEnable = GetComponent<ItemRotator>();
	}


	// Update is called once per frame
	void Update ()
	{
		if (enableRotation = true) {
			foreach (Transform t in allChildren) {
//				Debug.Log ("found the child");
				scriptEnable.enabled = !scriptEnable.enabled;
//				 time.deltatime changes the change from framrate to time
				//t.RotateAround (t.transform.position, Vector2.up, 45 * Time.deltaTime);
				//t.Rotate (new Vector3 (Random.Range (0, 45), Random.Range (0, 45), Random.Range (0, 45)) * Time.deltaTime);
				//t.localRotation = Quaternion.Euler (0, 0, Random.Range (0, 360f) * Time.deltaTime);
				//float randomVec3 = Random.Range (min, max);
				//t.localScale = Vector3.Scale (new Vector3 (1, 1, 1), new Vector3 (randomVec3, randomVec3, randomVec3));
			}
		}
	}

	// void fixedUpdate () {} is a function that uses time
}
