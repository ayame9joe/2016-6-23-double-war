using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public bool isPlayer1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Dot") {
			Destroy (other.gameObject);
			if (isPlayer1) {
				Defines.player1Score += 10;
			} else {
				Defines.player2Score += 10;
			}
		} else if (other.tag == "Player1Door") {
			Defines.player1FinalScore += Defines.player1Score;
			Defines.player1Score = 0;
		} else if (other.tag == "Player2Door") {
			Defines.player2FinalScore += Defines.player2Score;
			Defines.player2Score = 0;
		}
	}
}
