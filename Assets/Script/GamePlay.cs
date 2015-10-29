using UnityEngine;
using System.Collections;


public class GamePlay : MonoBehaviour {

	// Use this for initialization
	public Camera cam;
	public static GamePlay Instance;
	Vector3 speed = new Vector3(0.075f,0,0);
	public GameState gamestate = GameState.MENU;
	public Bird bird;
	public int SCORE;
	void Start () {
		Instance = this;
	}
	
	// Update is called once per frame
	void Update () 
	{
		cam.transform.Translate (speed);

		if (gamestate == GameState.ENDGAME) {
			speed.x*=0.9f;

		}
		GuiManager.Instance.current_score.text = ""+SCORE;
	}
	public void StartGame()
	{
		gamestate = GameState.GAMEPLAY;
		bird.GetComponent<Rigidbody2D>().gravityScale = 3;
		audiomanager.Instance.PlayAudio (audiomanager.Instance.wing_start);

		GuiManager.Instance.Dissmiss ();

		//GuiManager.Instance.ShowEnd ();
	}

	public void EndGame()
	{
		gamestate = GameState.ENDGAME;
		bird.GetComponent<Rigidbody2D>().gravityScale = 0;
		GuiManager.Instance.ShowEnd ();
	}

	public void ReStartGame()
	{
		//gamestate= GameState.GAMEPLAY

		Application.LoadLevel("1234");
	}
	

}
public enum GameState
{
	MENU,
	GAMEPLAY,
	ENDGAME
}