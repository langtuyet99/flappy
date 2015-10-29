using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GuiManager : MonoBehaviour {


	public static GuiManager Instance;
	public GameObject gui_start;
	public GameObject gui_end;
	public Text best_end;
	public Text best_start;
	public Text score_end;
	public Text current_score; 
	public int score;

	// Use this for initialization
	void Start () {
		Instance = this;
	}
	
	// Update is called once per frame
	void Update () {

		ShowStart ();

	}

	public void ShowStart()
	{
				gui_start.SetActive (true);
				gui_end.SetActive (false);
				int best = PlayerPrefs.GetInt ("best");
				best_start.text = "Your Best:" + best;
	}
	public void ShowEnd()
	{
		score = GamePlay.Instance.SCORE;
		gui_start.SetActive (false);
		gui_end.SetActive (true);
		score_end.text = "Your Score: " + score;
		int best = PlayerPrefs.GetInt("best");
		if (best < score) {
			best= score;
			PlayerPrefs.SetInt("best", best);
		
		}
		best_end.text = "Your Best :" + best;

		
		
	}

	public void Dissmiss()
	{
		gui_start.SetActive (false);
		gui_end.SetActive (false);
		
		
	}
}
