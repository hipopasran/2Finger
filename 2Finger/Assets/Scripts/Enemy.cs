using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    Rigidbody2D body;
    [RangeAttribute(-1, -10)]
    public int speed;

    // Use this for initialization
    void Start () {
        body = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void FixedUpdate () {

        body.velocity = new Vector2(0, speed);
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag=="Player")
        {
            Destroy(other.gameObject);
        }
        if(other.gameObject.name == "TrashDestroy")
        {
            Destroy(gameObject);
        }
    }

}
