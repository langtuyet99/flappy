using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Pipes : MonoBehaviour {


	public Object prefap_pipes;
	public float distance = 0.3f;
	public float last_x = 0.3f;
	List<GameObject> list = new List<GameObject>();


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (GamePlay.Instance.gamestate != GameState.MENU) {
				
	
						TryToAddPipe ();
				}
	}
	void TryToAddPipe()
	{
		if (GamePlay.Instance.cam.transform.localPosition.x + 22.6f - last_x > distance) {

			if(list.Count<10){
						GameObject g = Instantiate (prefap_pipes) as GameObject;
						g.transform.parent = this.transform;
						Vector3 target = new Vector3 ();
						//g.transform.localPosition = new Vector3(GamePlay.Instance.cam.transform.localPosition.x+22.6f);
						target.x = GamePlay.Instance.cam.transform.localPosition.x + 22.6f;
						target.y = Random.Range (-0.5f, 3f);
						g.transform.localPosition = target;
						last_x = target.x;

						list.Add (g);
				} 
		else {
			Vector3 target = new Vector3 ();

			target.x = GamePlay.Instance.cam.transform.localPosition.x + 22.6f;
			target.y = Random.Range (-0.5f, 3f);
			last_x = target.x;
			list[0].transform.localPosition = target;
			list.Add(list[0]);
			list.RemoveAt(0);

			}
		}
	
	}
}
