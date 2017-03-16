using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    public int Strength = 2;
    public int points = 1;

	// Use this for initialization
	void Start () {
		
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        Strength = Strength - 1; //Strength - = 1 (same thing)
        Debug.Log(Strength);

        GetComponent<SpriteRenderer>().color = new Color (1,1,1, Strength * 0.2f);

        if (Strength == 0) ;
        {
            gameObject.SetActive(false);
            FindObjectOfType<Ball>().BrickBroken(points);//worth(from ball script) = points(in this script)
            FindObjectOfType<Ball2>().BrickSmash();
            FindObjectOfType<Ball3>().BrickBroken3();
        }
    }
}
