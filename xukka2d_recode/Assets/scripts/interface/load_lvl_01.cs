using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class load_lvl_01 : MonoBehaviour
{

	// Use this for initialization
	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "hero"){
			SceneManager.LoadScene ("level_01_quarter_hick");
		}
	}
}


