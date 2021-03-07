using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour {

	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
            else if (Input.anyKey)
        {
            SceneManager.LoadScene("gameScene");
        }
	}
}
