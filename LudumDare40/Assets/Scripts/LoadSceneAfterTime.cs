using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneAfterTime : MonoBehaviour {

    public float timeBeforeLoading = 5f;
    public string sceneName;

	// Use this for initialization
	void Start () {
        Invoke("loadScene", timeBeforeLoading);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void loadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
