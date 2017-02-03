using UnityEngine;
using System.Collections;

public class CameraFading : MonoBehaviour {

	public Texture2D fadeOutTexture; //the texture that will overlay the screen; a black image
	public float fadeSpeed = 0.00001f; //the fading speed

	private int drawDepth = -1000; //the texture's order in the draw hierarchy; a low number will render on top
	private float alpha = 0f; //the texture's alpha value between 0 and 1
	private int fadeDir = -1; //the direction to fade: in = -1 or out = 1

    void Start()
    {
        BeginFade(-1);
    }

	void OnGUI () {

		//fade out/in the alpha value using a direction, a speed, and Time.deltatime to convert the operation to seconds
		alpha += fadeDir*fadeSpeed*Time.deltaTime;
		//force (clamp) the number between 0 and 1 because GUI.color uses alpha values between 0 and 1
		alpha = Mathf.Clamp01 (alpha);

		//set color of GUI (in this case texture), all color values remain the same and the alpha is set to the alpha variable
		GUI.color = new Color (GUI.color.r, GUI.color.g, GUI.color.b, alpha); //set the alpha value
		GUI.depth = drawDepth;
		GUI.DrawTexture (new Rect (0,0, Screen.width, Screen.height), fadeOutTexture); //draw the texture to fit the entire screen

	}

	public float BeginFade (int direction) {
        if (direction > 0) alpha = 0f;
        else alpha = 1f;

		fadeDir = direction;
		return (fadeSpeed); //return the fadeSpeed variable so it's easy to time the camera switch
	}

	//void SwitchCamera () 
	// alpha = 1; //use this if the alpha is not set to 1 by default
	//BeginFade(-1); //call the fade in function
	
}
