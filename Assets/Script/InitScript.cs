using UnityEngine;
using System.Collections;

public class InitScript : MonoBehaviour {




	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		this.transform.Rotate (Vector3.right * Time.deltaTime*100f);
	}
}
