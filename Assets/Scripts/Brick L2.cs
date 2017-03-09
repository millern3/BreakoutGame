using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickL2 : MonoBehaviour {

    public GameObject Brickbreaker;
    int Brick = 2;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    
    Debug.Log("Strong Brick");
        Brick = Brick - 1;
    
        if (Brick == 0)
    {
        DoBrickBreak();
    }

    void DoBrickBreak()
        {
        Brickbreaker.SetActive(true);
    }
  