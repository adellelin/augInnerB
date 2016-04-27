#pragma strict

public var original: GameObject;

function Start () {
	yield WaitForSeconds(8.0);
    Destroy(gameObject);
    original.SetActive(true);
    
}

function Update () {

}