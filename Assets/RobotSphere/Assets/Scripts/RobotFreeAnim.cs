using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotFreeAnim : MonoBehaviour {

	Vector3 rot = Vector3.zero;
	
	Animator anim;

	// Use this for initialization
	void Awake()
	{
		anim = gameObject.GetComponent<Animator>();
		gameObject.transform.eulerAngles = rot;
	}

	// Update is called once per frame
	

	
		

		// Roll
		void OnTriggerEnter(Collider other)
		{
			anim.SetBool("Open_Anim", true);
			anim.SetBool("Roll_Anim", true);
			
		}

		void OnTriggerExit(Collider other)
		{
			anim.SetBool("Roll_Anim", false);

		}

		
		

}
