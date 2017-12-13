﻿using UnityEngine;
using System.Collections;

public class AppleTree : MonoBehaviour {

	public GameObject applePrefab;
	public float speed = 1.0f;
	public float leftAndRightEdge = 10f;
	public float chanceToChangeDirections = .1f;
	public float secondsBetweenAppleDrops = 1f;

	// Use this for initialization
	void Start () {
		//Dropping apples every second
		InvokeRepeating("DropApple", 2f, secondsBetweenAppleDrops);
	}
	
	// Update is called once per frame
	void Update () {
		//Basic movement and changing directions
		Vector3 pos = transform.position;
		pos.x += speed * Time.deltaTime;
		transform.position = pos;

		if (pos.x < -(leftAndRightEdge)) {
			speed = Mathf.Abs(speed);
		} else if (pos.x > leftAndRightEdge) { //huge mistake here. prev: pos.x < leftAndRightEdge
            speed = -Mathf.Abs(speed);
		}
        //Debug.Log(string.Format("Speed: {0}, Pos: {1}", speed, pos.x));
    }

	void FixedUpdate(){
		if (Random.value < chanceToChangeDirections) {
			speed = speed * -1;
		}
	}

	void DropApple(){
		GameObject apple = Instantiate (applePrefab) as GameObject;
		apple.transform.position = transform.position;
	}
}
