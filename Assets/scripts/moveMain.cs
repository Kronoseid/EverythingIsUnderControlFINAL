using UnityEngine;
using System.Collections;

public class moveMain : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if ((Input.GetKey (KeyCode.LeftArrow)) || (Input.GetKey (KeyCode.A))){
			transform.position += new Vector3(-1f, 0f, 0f) * 10*Time.deltaTime;
		}
		if ((Input.GetKey (KeyCode.RightArrow)) || (Input.GetKey (KeyCode.D))){
			transform.position += new Vector3(1f, 0f, 0f) * 10*Time.deltaTime;
		}
		if ((Input.GetKey (KeyCode.UpArrow)) || (Input.GetKey (KeyCode.W)) || (Input.GetKey (KeyCode.Space))){
			transform.position += new Vector3(0f, 1f, 0f) * 10*Time.deltaTime;
		}
	}
}