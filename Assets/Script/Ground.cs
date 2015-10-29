using UnityEngine;
using System.Collections;

public class Ground : MonoBehaviour {

	// Use this for initialization

	public GameObject[] children;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		for (int i =0; i< children.Length; i++) {
			if(children[i].transform.localPosition.x < GamePlay.Instance.cam.transform.localPosition.x -19.2f)
			{
				children[i].transform.Translate(19.2f*children.Length,0,0);
			}
		}
	}
}
