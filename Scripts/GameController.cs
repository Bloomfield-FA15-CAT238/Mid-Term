using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	public GameObject player;
	public GameObject respawnPoint;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	 public void Respawn()
	{
		player.gameObject.transform.position = respawnPoint.gameObject.transform.position;
	}
}

	
