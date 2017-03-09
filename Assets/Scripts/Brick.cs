using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    public int Strength = 2;
	// Use this for initialization
	void Start () {
		
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        Strength = Strength - 1; //Strength - = 1 (same thing)
        Debug.Log(Strength);

        if (Strength == 0)
        {
            gameObject.SetActive(false);
            FindObjectOfType<Ball>().BrickBroken();
        }
    }
}
