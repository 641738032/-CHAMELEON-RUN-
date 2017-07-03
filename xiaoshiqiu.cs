using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xiaoshiqiu : MonoBehaviour {

	AudioManager am = null;
	// Use this for initialization
	void Start () {
		am = GameObject.Find ("Audio Sources").GetComponent<AudioManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider collider)
	{
		if (collider.tag == "man") {  //小人碰到了弹珠
			Debug.Log ("chixiaoqiu");
			Destroy (this.gameObject); //弹珠消失
			am.playPickupBonus ();
		}
	}
}
