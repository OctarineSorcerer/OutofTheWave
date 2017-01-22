using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {
    public bool alive;

    public GameObject player1;
    public GameObject player2;
    public GameObject gameOver1;
    public GameObject gameOver2;
    public GameObject panel;
    public AudioSource audio;
    bool check=true;
    

    // Use this for initialization
    void Start() {
        alive = true;
        
        

    }

    void gameOverFun1() //player 1 wins
    {
        if (check)
        {
            audio.Play();
            check = false;
        }
        gameOver1.SetActive(true);
        panel.SetActive(true);

    }

    void gameOverFun2() //player 2 wins
    {   if (check)
        {
            audio.Play();
            check = false;
        }
        panel.SetActive(true);
        gameOver2.SetActive(true);

    }
    

      // Update is called once per frame
    void Update () {
        if (player1.transform.position.y < -2 || alive==false)
        {
            
            gameOverFun1();
            
        }
        if (player2.transform.position.y < -2 || alive == false)
        {
           
            gameOverFun2();
        }
		
	}
}
