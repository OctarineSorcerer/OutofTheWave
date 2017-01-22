using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{
    public int sceneToLoad;
    public float waitTime;

	// Use this for initialization
	IEnumerator Start () {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene(sceneToLoad);
	    Debug.Log("Load scene");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
