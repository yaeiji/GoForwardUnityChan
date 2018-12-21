using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class CubeContrller : MonoBehaviour {

	//キューブの移動速度
	private float speed= -0.2f;

	//消滅位置
	private float deadLine= -10;

	private AudioSource sound;



	// Use this for initialization
	void Start () {
		sound = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {

		//キューブを移動させる
		transform.Translate(this.speed,0,0);

		//画面に出たら破棄する
		if(transform.position.x<this.deadLine){
			Destroy (gameObject);
		}
		
	}

	void OnCollisionEnter2D(Collision2D other){
		//Debug.Log("a");
		if (other.gameObject.tag != "Unitychan") {
			sound.PlayOneShot (sound.clip);
		//	Debug.Log("a");
		} 

	}
}
