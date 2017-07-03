using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColiderTest : MonoBehaviour {
	 
	public GameObject obj;

	Material mat;
	Material cubemat;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
//		mat = transform.Find("Character1_Reference/Character1_Hips/Character1_LeftUpLeg/Character1_LeftLeg/Character1_LeftFoot/HootL" ).GetComponent<MeshRenderer>().material;
		mat = GetComponent<MeshRenderer> ().material;
//		cubemat = obj.GetComponent<MeshRenderer> ().material;
//		if (mat != cubemat)
//			Debug.Log ("aaaaa");
//		else
//			Debug.Log ("bbbb");
	}

	void onCollisionEnter(Collision col)
	{
//		if (col.gameObject.tag == "cube") {
//			obj = GameObject.Find (col.gameObject.name);
//			cubemat = obj.GetComponent<MeshRenderer> ().material;
//			if (mat != cubemat)
//				Debug.Log ("aaaaa");
//			else
//				Debug.Log ("bbbb");
//		}
		Debug.Log("碰到了");
	}
}
