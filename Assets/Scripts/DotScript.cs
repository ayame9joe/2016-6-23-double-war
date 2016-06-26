using UnityEngine;
using System.Collections;

public class DotScript : MonoBehaviour {

	Vector3 speed;

	float maxSpeed = 0.1f;

	int directionChangeTimes = 0;

	// Use this for initialization
	void Start () {
		speed = new Vector3 (Random.Range (-maxSpeed, maxSpeed), 
			Random.Range (-maxSpeed, maxSpeed), 0);


	}
	
	// Update is called once per frame
	void Update ()
	{

		if (directionChangeTimes % 2 == 0) {
			this.transform.Translate (speed);
		} else {
			this.transform.Translate (new Vector3 (-speed.x, -speed.y, 0));
		}

		if (Vector3.Distance (this.transform.position, new Vector3 (0, 0, 0)) > Defines.width / 2) {

			directionChangeTimes++;
			//Debug.Log (changeDirection);

		}
	
	
	}
}
