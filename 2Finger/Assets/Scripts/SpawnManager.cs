using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {

    public Transform[] LeftArr;
    public Transform[] RightArr;

    public GameObject[] Obj;

    //public GameObject Meteor;
    //public GameObject Fuel;
    private float delay;
    public float timeDelay = 2f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        delay = delay - Time.deltaTime;

        if (delay <= 0 && gameObject.activeInHierarchy == true)
        {
            int numObj = Random.Range(0, 2);
            int num = Random.Range(0, 2);
            Transform.Instantiate(Obj[numObj], LeftArr[num].position, LeftArr[num].rotation);

            numObj = Random.Range(0, 2);
            num = Random.Range(0, 2);
            Transform.Instantiate(Obj[numObj], RightArr[num].position, RightArr[num].rotation);


            delay = timeDelay;
        }
        if (gameObject.activeInHierarchy == false)
        {
            delay = 0;
        }
    }
}

