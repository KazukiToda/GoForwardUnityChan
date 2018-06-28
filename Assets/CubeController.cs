using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CubeController : MonoBehaviour {

	// キューブの移動速度
	private float speed = -0.2f;
	// 消滅位置
	private float deadLine = -10;

	AudioSource audioSource;
	public AudioClip audioClip = new AudioClip();

	// Use this for initialization
	void Start(){
		audioSource = gameObject.AddComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {
		// キューブを移動させる
		transform.Translate (this.speed, 0, 0);

		// 画面外に出たら破棄する
		if (transform.position.x < this.deadLine){
			Destroy (gameObject);
		}
	}
	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.name == "UnityChan2D") {
			
		} else {
			audioSource.PlayOneShot (audioClip);
		}
	}
}

	