using UnityEngine;
using System.Collections;

public class DoomDeath : MonoBehaviour {
	GameController Death;

	// Use this for initialization


		  public void OnTriggerEnter(Collider other)
		{
			Death.Respawn();
		}
		
}
			             
	// Update is called once per frame
	