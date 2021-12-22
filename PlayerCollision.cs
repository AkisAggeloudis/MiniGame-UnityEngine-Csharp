using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

	public NewBehaviourScript movement;
	
	

	//to gia an kati xtipisei me kati tha graftei sto console
    void OnCollisionEnter (Collision collisionInfo)
	{
		if(collisionInfo.collider.tag == "Obstacle" )
		{
			movement.enabled = false;
			FindObjectOfType<GameManager1>().EndGame();
		}
	}
}
