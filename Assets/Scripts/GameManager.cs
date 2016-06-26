using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public GameObject dot;

	public GameObject[] players = new GameObject[2];

	public Text player1ScoreText;
	public Text player2ScoreText;
	public Text player1FinalScoreText;
	public Text player2FinalScoreText;


	// Use this for initialization
	void Start () {

		// Oots Initialization
		for (int i = 0; i <= Defines.numberOfDots; i++) {

			float tempRangeX = Random.Range (-Defines.width / 2, Defines.width / 2);
			float tempRangeY = Random.Range(-Defines.height / 2, Defines.height / 2);

			GameObject.Instantiate (dot, new Vector3 (tempRangeX, tempRangeY, 0), Quaternion.identity);
		}
	
	}
	
	// Update is called once per frame
	void Update () {


		PlayerMove ();
		UIDisplay ();
	
	}

	void UIDisplay () {
		player1ScoreText.text = Defines.player1Score.ToString ();
		player2ScoreText.text = Defines.player2Score.ToString ();
		player1FinalScoreText.text = Defines.player1FinalScore.ToString ();
		player2FinalScoreText.text = Defines.player2FinalScore.ToString ();
	}

	void PlayerMove () {

		// Mouse Test Mode
		if (Input.GetMouseButtonDown (0) || Input.GetMouseButton(0)) {
			players [0].transform.position = Camera.main.ScreenToWorldPoint (new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));
		}

		// Touch Mode
		if (Input.touchCount > 0) {
			for (int i = 0; i < players.Length; i++) {
				if (Input.touches [1].phase == TouchPhase.Moved) {
					players[i].transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.touches [i].position.x, Input.touches[i].position.y,10));
				}
			}
		}

		// TODO: Controller Mode
		
	}
}
