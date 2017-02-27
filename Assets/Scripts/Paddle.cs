using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    Rigidbody2D rigidBody;
    float speed = 5;

    // Use this for initialization
    void Start () {
        rigidBody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update () {
        //GetComponent<Rigidbody2D>().velocity = new Vector2(x*5, 0); transform.Translate(0.005f, 0, 0);
        float x = Input.GetAxisRaw("Horizontal");
        x = x * speed;
        rigidBody.velocity = new Vector2(x, 0);
	}
}
