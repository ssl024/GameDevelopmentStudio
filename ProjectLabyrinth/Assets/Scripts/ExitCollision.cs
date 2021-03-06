﻿using UnityEngine;
using System.Collections;


public class ExitCollision : MonoBehaviour {


	public GameObject player;
    public GameObject loadResult;
	private Collider collider;
    private bool hasReached;

    static float wRatio = .666f;
    static float hRatio = .5f;
    static float w = Screen.width;
    static float h = Screen.height;
    static float frameWidth = w * wRatio;
    static float frameHeight = h * hRatio;

    static float frameX = w * (1 - wRatio) / 2;
    //static float frameY = h * (1 - hRatio) / 2;
    Rect win = new Rect(frameX + frameWidth/2, frameHeight / 2, 100, 100);
	void Start() 
	{
        Debug.Log("Public Player Var: " + player);
	}
	void OnTriggerEnter (Collider other)
	{
        Debug.Log("Trigger is working");
        Debug.Log("Object: " + other.gameObject);
        if (other.gameObject.name == player.name)
        {
            hasReached = true;
        }
	}
    void OnGUI()
    {
        if (hasReached)
        {
            if (GUI.Button(win, "Win the Game!"))
            {
                Instantiate(loadResult, new Vector3(0, 0, 0), Quaternion.identity);
            }
        }
    }
	/*void OnCollisionStay (Collision other)
	{
		Debug.Log ("Object Inside the trigger");
	}
	
	void OnCollisionExit (Collision other)
	{
		Debug.Log ("Object has Exited the trigger");
	}*/
}
