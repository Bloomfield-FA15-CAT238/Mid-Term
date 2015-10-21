using UnityEngine;
using System.Collections;

public class SpawnPoint : MonoBehaviour {
	public SpawnPoint prefab;
	
	void Update () {
		if (Input.GetKeyDown (KeyCode.Backspace)) {
			Instantiate (prefab);
		} else if (Input.GetKeyDown (KeyCode.KeypadEnter)) {
			Instantiate (prefab, this.transform.position = new Vector3 (-350.74f, 20.9f, 72.84f) , this.transform.rotation);
		}
	}
}