using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager1 : MonoBehaviour
{

	public float restartDelay = 1f;

	bool gameHasEnded = false;

	public GameObject completeLevelUI; 

	public GameObject failedLevelUI;

	

	public void CompleteLevel ()
	{
		completeLevelUI.SetActive(true);
	}

	

	public void EndGame()
	{
		
		
		
		if( gameHasEnded == false)
		{
			
			gameHasEnded = true;
			Invoke("Pop", 2);
			Invoke("Restart",  restartDelay);
			AllFails.FailsValue +=1;
			FinalScore.failsValue +=1;
		}
		
	}

	public void Pop()
	{
		failedLevelUI.SetActive(true);
	}

	void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
