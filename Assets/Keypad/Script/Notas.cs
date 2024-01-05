using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Notas : MonoBehaviour
{
   
   public GameObject character;

   public GameObject notaVisual;

   void Start()
   {
    notaVisual.SetActive(false);
   }

   void OnTriggerEnter(Collider other){
    notaVisual.SetActive(true);
   }
   void OnTriggerExit(Collider other){
    notaVisual.SetActive(false);
   }
}
