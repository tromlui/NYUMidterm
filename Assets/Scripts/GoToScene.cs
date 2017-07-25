using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoToScene : MonoBehaviour {

	public string sceneName;

	public void LoadScene() {

		SceneManager.LoadScene (sceneName);
	}


	static public void LoadSceneNamed (string name) {
		SceneManager.LoadScene (name);
	}

}