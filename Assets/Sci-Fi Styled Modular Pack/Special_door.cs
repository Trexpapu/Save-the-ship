using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Special_door : MonoBehaviour
{

    Animator anim;
    private BoxCollider boxCollider;
    
    private bool entraste;
    public GameObject puerta;
    public GameObject salida;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        boxCollider=salida.GetComponent<BoxCollider>();
    }
    void Update()
    {
        if(entraste){
            
            boxCollider.isTrigger=true;
        }else{
            boxCollider.isTrigger=false;
        }
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        anim.SetBool("character_nearby", true);
        entraste=true;
    }

     void OnTriggerExit(Collider other)
    {
        anim.SetBool("character_nearby", false);
        entraste=false;
    }
    
}
