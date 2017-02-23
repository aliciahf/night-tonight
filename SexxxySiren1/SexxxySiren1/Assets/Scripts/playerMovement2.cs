using UnityEngine;
using System.Collections;

public class playerMovement2 : MonoBehaviour {

	public float playerSpeed = 1f;
    public KeyCode up;
    public KeyCode down;
	public KeyCode right; 
	public KeyCode left;

    public KeyCode up2;
    public KeyCode down2;
    public KeyCode right2;
    public KeyCode left2;

    Animator animator;

	void Start (){
		animator = GetComponent<Animator>();
	}

	void Update (){

		//float h = Input.GetAxis("Horizontal");


		if (Input.GetKey (up) || Input.GetKey (up2)) {//Press up arrow key to move forward on the Y AXIS
			transform.Translate (0, playerSpeed * Time.deltaTime, 0);
			animator.SetBool ("isUp", true);
		} else {
			animator.SetBool("isUp", false);
		}
		if (Input.GetKey (down) || Input.GetKey(down2)) {
			transform.Translate (0, -playerSpeed * Time.deltaTime, 0);
			animator.SetBool ("isDown", true);
		} else {
			animator.SetBool ("isDown", false);
		}

		if (Input.GetKey (left) || Input.GetKey(left2)) {
			transform.Translate (-playerSpeed * Time.deltaTime, 0, 0);
			animator.SetBool ("isLeft", true);
		} else {
			animator.SetBool ("isLeft", false);
		}
		if(Input.GetKey(right) || Input.GetKey(right2))
		{
			transform.Translate(playerSpeed * Time.deltaTime,0 ,0);
			animator.SetBool("isRight", true);
		} 
		else {
			animator.SetBool ("isRight", false);
		}
	}
}
