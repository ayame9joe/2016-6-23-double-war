using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public GameObject dot;

	public GameObject[] players = new GameObject[2];


	// Use this for initialization
	void Start () {

		for (int i = 0; i <= Defines.numberOfDots; i++) {

			float tempRangeX = Random.Range (-Defines.width / 2, Defines.width / 2);
			float tempRangeY = Random.Range(-Defines.height / 2, Defines.height / 2);

			GameObject.Instantiate (dot, new Vector3 (tempRangeX, tempRangeY, 0), Quaternion.identity);


			//Debug.Log (tempRangeX + Defines.minRangeX + "/" + tempRangeY );
			//Debug.Log(tempRangeY);
		}
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.touchCount > 0) {
			for (int i = 0; i < players.Length; i++) {
				if (Input.touches [1].phase == TouchPhase.Moved) {
					players[i].transform.position = Camera.main.ScreenToWorldPoint(Input.touches [i].position);
				}
			}
		}
	
	}
}
