using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CubeCollision : MonoBehaviour {

	private AudioSource audioSource;


	void Start(){ 
		audioSource = gameObject.GetComponent<AudioSource> ();
	}
	void OnCollisionEnter2D (Collision2D other){

		Debug.Log ("Hello");
			if(other.gameObject.tag == "CubePrefab")
			{
			audioSource.Play();
		}else if(other.gameObject.tag == "ground"){
			audioSource.Play();
		}
	}

}