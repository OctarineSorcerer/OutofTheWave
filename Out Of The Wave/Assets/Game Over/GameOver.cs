using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{

    public float yCheck = -3.0f;
    public GameObject player1;
    public GameObject player2;
    public GameObject gameOver1;
    public GameObject gameOver2;
    public GameObject panel;
    public AudioSource audio;
    
    GameObject hideOnFinish;
    GameObject stones;
    bool check = true;

    // Use this for initialization
    void Start() {
        
        hideOnFinish = GameObject.Find("TiltedPlane");
        stones = GameObject.Find("Level");
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
    { if (check)
        {
            audio.Play();
            check = false;
        }
        panel.SetActive(true);
        gameOver2.SetActive(true);


    }


    // Update is called once per frame
    void Update() {
        if (player1.transform.position.y < yCheck )
        {
            
            hideOnFinish.SetActive(false);
            stones.SetActive(false);
            gameOverFun1();

        }
        else if (player2.transform.position.y < yCheck)
        {
            
            hideOnFinish.SetActive(false);
            stones.SetActive(false);
            gameOverFun2();
        }

    }
    
}
