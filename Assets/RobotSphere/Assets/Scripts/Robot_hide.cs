using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot_hide : MonoBehaviour
{
  Vector3 rot = Vector3.zero;
	
	Animator anim;

	// Use this for initialization
	void Awake()
	{
		anim = gameObject.GetComponent<Animator>();
		gameObject.transform.eulerAngles = rot;
	}

	void Start()
    {
        anim.SetBool("Open_Anim", true);
    }
	

	
		

		// Roll
		void OnTriggerEnter(Collider other)
		{
			anim.SetBool("Open_Anim", false);
			
			
		}

		void OnTriggerExit(Collider other)
		{
			
            anim.SetBool("Open_Anim", true);
		}

		
		

}



