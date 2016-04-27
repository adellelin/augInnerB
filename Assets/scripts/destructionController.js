#pragma strict

function Start () {

}

public var remainsPieces: GameObject;

function Update()
 {
 
 
     if(Input.GetKeyDown("space"))
     {
     	 Instantiate(remainsPieces, transform.position, transform.rotation); 
         gameObject.SetActive(false);
     }
 }