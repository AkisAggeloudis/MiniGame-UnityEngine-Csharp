using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
		public static int failsValue;
	  public static int i=1;

		public Text  highScore;

		public int HighScore1;
		public int prev;
		public int show;
	
    // Start is called before the first frame update
    void Start()
    {
		 highScore = GetComponent<Text>();
		 if(i==1)
		 {
			HighScore1 = 4790 - (failsValue * 10);
			prev = HighScore1;
		 }

		 HighScore1 = 4790 - (failsValue * 10);
		 if(HighScore1 >= prev)
		 {
		 	 
			 show = HighScore1;
			 highScore.text =show.ToString("0");
			 prev = HighScore1;
		 }
		 else
		 {
		 	 highScore.text =prev.ToString("0");
		 }
    }

    
    
}
