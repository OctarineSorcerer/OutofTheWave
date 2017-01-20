using System;
using UnityEngine;
using System.Collections;

public class ArenaFalling : MonoBehaviour
{
    public GameObject Arena; //If needed we can just find this within the scene
    public bool insideArena;
    private Bounds arenaBounds;

	// Use this for initialization
	void Start () {
        //Set the bounds that we're checking if we're outside of
	    try
	    {
	        arenaBounds = Arena.GetComponent<BoxCollider2D>().bounds;
            Debug.Log("Bounds loaded");
	    }
	    catch (MissingComponentException ex)
	    {
	        Debug.LogError("The arena object didn't have a boxCollider2D component added - which it needs");
	    }
	    Debug.Log(arenaBounds);
    }
	
	// Update is called once per frame
	void Update ()
	{
	    insideArena = arenaBounds.Contains(gameObject.transform.position); //Will likely change to use collider closestpoints on bounds and then distance between the two for falling off? Or just full collider for this
	}
}
