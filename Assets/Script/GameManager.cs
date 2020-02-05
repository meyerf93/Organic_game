using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public Ressources_manager ressources_Manager;

	// Use this for initialization
	void Start () {
		
		ressources_Manager.CreateRessourceManager(1000,100,25000,100,500000,100);
	}

	// Update is called once per frame
	void Update () {
		
	}
}
