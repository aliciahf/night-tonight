using UnityEngine;
using System.Collections;

public class samePos : MonoBehaviour {

	public GameObject boat;
	float posX; 
	float posY;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnEnable() {

		posX = boat.GetComponent<Transform>().position.x; 
		posY = boat.GetComponent<Transform> ().position.y;
		transform.position = new Vector2(posX, posY);
	
	}
}
