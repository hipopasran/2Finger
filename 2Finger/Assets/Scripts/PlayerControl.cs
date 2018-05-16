using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    public GameObject Rocket;
    Rigidbody2D body;
    public Transform LeftPos;
    public Transform RightPos;

    void OnMouseDown()
    {
        Debug.Log("кек");
    }

    void Awake()
    {
        body = Rocket.GetComponent<Rigidbody2D>();
    }
	
}
