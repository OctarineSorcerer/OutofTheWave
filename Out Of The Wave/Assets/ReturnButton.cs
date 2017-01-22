using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnButton : MonoBehaviour
{
    public GameObject hide1;
    public GameObject hide2;
    public GameObject menubutt;

    // Use this for initialization
    void Start()
    {
      
    }

   
    public void hide()
    {
        
        hide1.SetActive(false);
        hide2.SetActive(false);
        menubutt.SetActive(true);
    }
}
