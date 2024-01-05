using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open_Close : MonoBehaviour
{

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        anim.SetBool("character_nearby", true);
    }

     void OnTriggerExit(Collider other)
    {
        anim.SetBool("character_nearby", false);
    }
}
