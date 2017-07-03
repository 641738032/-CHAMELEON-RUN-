
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tongguan : MonoBehaviour {
	Material cubemat;
	Material mat;
	public Material pink;
	public Material yellow;
	public GameObject obj; 

	AudioManager am = null;
	// Use this for initialization
	void Start () {

		am = GameObject.Find ("Audio Sources").GetComponent<AudioManager> ();
//		cubemat = GetComponent<MeshRenderer> ().material;;
//		mat = obj.GetComponent<MeshRenderer> ().material;
	}
	
	// Update is called once per frame
	void Update () {
//		cubemat = GetComponent<MeshRenderer> ().material;;
//		mat = obj.GetComponent<MeshRenderer> ().material;

	}
	void OnCollisionEnter(Collision collision){
		if (collision.collider.CompareTag ("man")) {   //小人与积木碰撞
			Debug.Log ("cccc");

			Debug.Log (this.tag);   //输出当前积木的Tag（颜色）信息
			Debug.Log (obj.tag);    //输出obj的Tag（颜色）信息，即小人的颜色信息
//			
			if (this.tag != obj.tag){  //如果两个Tag不相等，说明颜色不同，游戏结束
				Debug.Log("dead");
				am.playWrongColor ();
				SceneManager.LoadScene ("gameover");
			}			

		}
	}
}
