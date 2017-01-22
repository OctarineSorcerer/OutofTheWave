using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour {
    private GameObject canvas;
    private GameObject text1;
    private GameObject text2;
    private void Start()
    {
        canvas =  GameObject.Find("Canvas");
        text1 = GameObject.Find("GameOverText1");
        text2 = GameObject.Find("GameOverText1");
    }

    public void Reload()
    {
        
        Application.LoadLevel(Application.loadedLevel);
        
    }
}
