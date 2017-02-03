using UnityEngine;
using System.Collections;

public class playerMovement2 : MonoBehaviour {

	public float playerSpeed = 1f;
	public KeyCode up = KeyCode.UpArrow;
	public KeyCode down = KeyCode.DownArrow;
	public KeyCode right = KeyCode.RightArrow; 
	public KeyCode left = KeyCode.LeftArrow; 
	Animator animator;

	void Start (){
		animator = GetComponent<Animator>();
	}

	void Update (){

		float h = Input.GetAxis("Horizontal");


		if (Input.GetKey ("up")) {//Press up arrow key to move forward on the Y AXIS
			transform.Translate (0, playerSpeed * Time.deltaTime, 0);
			animator.SetBool ("isUp", true);
		} else {
			animator.SetBool("isUp", false);
		}
		if (Input.GetKey ("down")) {
			transform.Translate (0, -playerSpeed * Time.deltaTime, 0);
			animator.SetBool ("isDown", true);
		} else {
			animator.SetBool ("isDown", false);
		}

		if (Input.GetKey ("left")) {
			transform.Translate (-playerSpeed * Time.deltaTime, 0, 0);
			animator.SetBool ("isLeft", true);
		} else {
			animator.SetBool ("isLeft", false);
		}
		if(Input.GetKey("right"))
		{
			transform.Translate(playerSpeed * Time.deltaTime,0 ,0);
			animator.SetBool("isRight", true);
		} 
		else {
			animator.SetBool ("isRight", false);
		}
	}
}
