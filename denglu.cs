using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class denglu : MonoBehaviour {
	public InputField usrName;
	public InputField usrPass;
	string name;
	string pass;
	void Start () {

	}
	public void InputNumber(string str){
		name = str;
	}

	public void InputPass(string str){
		pass = str;
	} 

	// Update is called once per frame

	void Update () {

	}
	public void startGame() {
		Debug.Log ("用户名为："+usrName.text+"密码为："+usrPass.text);
		SceneManager.LoadScene("scene01");
	}
	public void zanting() {
		Time.timeScale = 0;
	}
	public void jixu() {
		Time.timeScale = 1;
	}
}
