﻿using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static GameManager instance;
	public Inventory inventory = new Inventory();
	// Use this for initialization
	void Start () {
		if (instance == null) {
			instance = this;
		}
	}

}
