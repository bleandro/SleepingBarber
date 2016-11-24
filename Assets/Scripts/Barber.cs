﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Barber : MonoBehaviour {
	//public bool cutting;
	public Barber barberScript; 	
	public Toggle toggleAwake;		// reference to ToggleAwake Script
	public BarberShop barbershopScript;
	private bool Awake;

	void Start () {
		barbershopScript = GameObject.Find("MainController").GetComponent<BarberShop>();
		barberScript = this.GetComponent<Barber>();
		toggleAwake = GameObject.Find("ToggleAwake").GetComponent<Toggle>();
		sleep();
	}

	public void sleep() {
		//TODO animate Barber sleeping
		Debug.Log("Barber Sleeps ZzZ");
		this.Awake = false;
		toggleAwake.isOn = this.Awake;
	}

	public void wakeUp() {
		//TODO animate Barber waking up
		Debug.Log("Barber is Waking Up");
		this.Awake = true;
		toggleAwake.isOn = this.Awake;
		barbershopScript.barberWorking();		// barber's loop
	}

//	public void Update ()
//	{
//		barbershopScript.barberWorking();		// barber's loop
//	}

	public bool isAwake() {
		return this.Awake;
	}

	public void OnGUI()
	{
		//toggleAwake.isOn = this.Awake;
	}

}
