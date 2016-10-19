using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space) && Time.frameCount > 10)
        {
            SceneManager.LoadScene("title");
        }
    }
}
