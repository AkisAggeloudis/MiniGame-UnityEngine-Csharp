using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
	public Rigidbody rb;

	public float forwardForce = 2000f;
	public float sidewayForce = 500f;
 


    // FixedUpdate is called once per frame
	//to FixedUpdate to exw gia physics
    void FixedUpdate()
    {
		//adds foward force
        rb.AddForce(0 , 0 , forwardForce * Time.deltaTime);

		//adds force sideways with d or a 
		if(Input.GetKey("d"))
		{
			rb.AddForce(sidewayForce  * Time.deltaTime, 0 , 0, ForceMode.VelocityChange);
		}

		if(Input.GetKey("a"))
		{
			rb.AddForce(-sidewayForce  * Time.deltaTime, 0 , 0, ForceMode.VelocityChange);
		} 

		if ( rb.position.y < -1f) 
		{
			FindObjectOfType<GameManager1>().EndGame(); 
		}

		
    }
}
