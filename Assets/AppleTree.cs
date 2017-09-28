using System.Collections;
using UnityEngine;

public class AppleTree : MonoBehaviour {

	//Prefab for instantiating apples 
	public GameObject applePrefab;

	//Speed at which the AppleTree moves in meteres/sec
	public float speed = 1f;

	//Distance to where AppleTree turns around 
	public float leftAndRightEdge = 10f;

	//Chance that AppleTree will change directions
	public float chanceToChangeDirections = 0.1f;

	//Rate at which Apples will be instantiated
	public float secondsBetweenAppleDrops = 1f;


	void Start () {
		//Dropping apples every second
	}

	void Update () {
		//Basic Movement
		//Changing Direction
	}
}
