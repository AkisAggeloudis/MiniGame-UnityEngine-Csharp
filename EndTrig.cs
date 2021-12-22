using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrig : MonoBehaviour
{

	public GameManager1 gameManager;

	void OnTriggerEnter ()
	{
		gameManager.CompleteLevel();
	}
}
