using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    public GameObject Rocket;
    Rigidbody2D body;
    public Transform LeftPos;
    public Transform RightPos;
    public float XVel;

    public float speed = 2f;
    public float rotation = 30f;


    void OnMouseDown()
    {
        
       // Rocket.isStatic = false;
        Debug.Log("кек");
        if (Rocket.transform.position.x <= LeftPos.position.x)
        {
            XVel = speed;
            // Rocket.GetComponent<Transform>().Rotate(0,0,-45);
            body.rotation = -rotation;
            Debug.Log("Право");
        }
        else if(Rocket.GetComponent<Transform>().position.x >= RightPos.position.x)
        {
            XVel = -speed;
            Debug.Log("Лево");
           // Rocket.GetComponent<Transform>().Rotate(0, 0, 45);
            body.rotation = rotation;
        }
        else
        {
            XVel = -XVel;
            // Rocket.GetComponent<Transform>().Rotate(0, 0, -(Rocket.GetComponent<Transform>().rotation.z));
            body.rotation = -body.rotation;
        }
    }

    void Awake()
    {
        body = Rocket.GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        //Rocket.isStatic = true;
        if ((Rocket.GetComponent<Transform>().position.x <= LeftPos.position.x && XVel<0) || ( Rocket.GetComponent<Transform>().position.x >= RightPos.position.x && XVel > 0))
        {
            Debug.Log("Stop");
            XVel = 0;
            body.rotation = 0;
           // Rocket.isStatic = true;
        }


        body.velocity = new Vector2(XVel, 0);
        
        
    }
	
}
