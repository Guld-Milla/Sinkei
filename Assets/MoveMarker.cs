﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMarker : MonoBehaviour {

//	public float speed;
//	public GameObject hitcard;
//	public GameObject marker;
//	//public bool hit = false;
//
//	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
//
//		transform.position += transform.forward * Time.deltaTime * speed;
//
//		Destroy (this.gameObject, 2f);


	}

	void OnTriggerEnter(Collider other){
//		if(other.gameObject.tag == "Card"){
//			hitcard = other.gameObject;
//
//
//			Destroy(this.gameObject);
//			Transform cardTransform = other.transform;
//			Instantiate (marker, cardTransform.position, cardTransform.rotation + Quaternion.Euler(0,90f,0));
//		//	other.GetComponent<reverseCard> ().marker = this.gameObject;
//		}
	}
}
