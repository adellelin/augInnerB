#pragma strict

function Start () {

}

public var chainPrefab: GameObject;

function Update()
 {
 
 
     if(Input.GetKeyDown("space"))
     {
     	 Instantiate(chainPrefab, transform.position, transform.rotation); 
         Destroy(gameObject);
     }
 }