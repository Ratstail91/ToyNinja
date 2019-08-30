using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaScript : MonoBehaviour {
	Toy.ToyBehaviour behaviour = null;

	void Awake() {
		behaviour = GetComponent<Toy.ToyBehaviour>();
	}

	void Update() {
		if (Input.GetKey("p")) {
			//run arbitrary code at runtime
			Toy.Plugin.Globals globals = new Toy.Plugin.Globals();

			Debug.Log(globals.Get("score"));
		}
	}
}