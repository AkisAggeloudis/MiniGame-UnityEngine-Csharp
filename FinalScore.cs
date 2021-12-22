using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{

	public static int failsValue;
	
   
	public Text  finalScore;


	
    void Start()
	{
		 finalScore = GetComponent<Text>();
		
		 
		 finalScore.text =(4790 - (failsValue * 10)).ToString("0");	 
	}
}
