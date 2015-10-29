using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour {

	// Use this for initialization

	void Start () {
	
		GetComponent<Rigidbody2D>().gravityScale = 0;


	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetMouseButtonDown (0)) {
			//rigidbody2D.AddForce(new Vector2(0,500));	
			if(GamePlay.Instance.gamestate!=GameState.ENDGAME){
			GetComponent<Rigidbody2D>().velocity= new Vector2(0,12);

			if(GamePlay.Instance.gamestate== GameState.MENU)
				GamePlay.Instance.StartGame();
			audiomanager.Instance.PlayAudio (audiomanager.Instance.wing);
			}
			else GamePlay.Instance.ReStartGame();
		}
		//float angle = Mathf.Atan2 (rigidbody2D.velocity.y, rigidbody2D.velocity.x);
		float angle = Mathf.Atan2 (GetComponent<Rigidbody2D>().velocity.y, 10);
		transform.eulerAngles = new Vector3 (0, 0, angle * 57.3f);
	}


	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log ("score");
		audiomanager.Instance.PlayAudio (audiomanager.Instance.score);
		GamePlay.Instance.SCORE += 1;
		Debug.Log ("score:" + GamePlay.Instance.SCORE);

	}

	void OnCollisionEnter2D(Collision2D other)
	{
		Debug.Log("die");
		audiomanager.Instance.PlayAudio (audiomanager.Instance.die);

		GamePlay.Instance.EndGame ();
	
	}


	/*
	void FixedUpdate() {
		rigidbody.AddForce(0, 10, 0);
	}

*/
}
