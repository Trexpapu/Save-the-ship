using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intrucciones : MonoBehaviour
{
    public GameObject intruccion;
    void Start()
   {
    intruccion.SetActive(false);
   }
    void OnTriggerEnter(Collider other){
    intruccion.SetActive(true);
   }
   void OnTriggerExit(Collider other){
    intruccion.SetActive(false);
   }

}
