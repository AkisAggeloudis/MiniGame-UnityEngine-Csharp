using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
	

	
	
	public void RestartGame()
	{
		SceneManager.LoadScene("Menu");
		HighScore.i += 1;
	}

	public void Quit()
	{
		Application.Quit();
		HighScore.i += 1;
	}
    
}
