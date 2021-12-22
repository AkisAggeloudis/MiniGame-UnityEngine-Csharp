using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AllFails : MonoBehaviour
{	
	public static int FailsValue;
   
	public Text allFails;

	


	void Start()
	{
		 allFails = GetComponent<Text>();
		 
		 
		 allFails.text = FailsValue.ToString("0");
		 
	}
}

