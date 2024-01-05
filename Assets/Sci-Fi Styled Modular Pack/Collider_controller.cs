using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider_controller : MonoBehaviour
{

    
    private BoxCollider boxCollider;
    private System.Random random;
    int randomNumber;
    public GameObject piso1;
    public GameObject piso2;
    // Start is called before the first frame update
    void Start()
    {
       
      
        random=new System.Random();

         randomNumber= random.Next(1, 3);
         
    if(randomNumber==1){
        boxCollider=piso1.GetComponent<BoxCollider>();
        boxCollider.enabled=true;
    }else if(randomNumber==2){
        boxCollider=piso2.GetComponent<BoxCollider>();
        boxCollider.enabled=true;
    }
       
    }
  

    
}
