using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneTask : MonoBehaviour
{
    // Start is called before the first frame update
   public bool dentro;
   private MovementInput controller;
   public GameObject character;
   // private GameObject taskInstance;
    public GameObject taskPrefab;
    
    

    void Start()
   {
    controller=character.GetComponent<MovementInput>();
   // taskInstance = Instantiate(taskPrefab);
    taskPrefab.SetActive(false);
    
   }

   void Update()
   {
    if(controller.activar){
            Debug.Log("Le pico al boton y no se mueve");
            SpawnPrefab();
        }
    if(dentro && !controller.activar){
            RemoveObject();
        }
   }

    void OnTriggerEnter(Collider other)
    {
        // Aquí puedes agregar la lógica para la tarea que deseas activar al entrar en la zona invisible.
        // Por ejemplo, puedes activar una animación, reproducir un sonido, cambiar una variable, etc.
        Debug.Log("Entro a la zona");
        dentro=true;
        
    }

    void OnTriggerExit(Collider other)
    {
        // Aquí puedes agregar la lógica para revertir la tarea que se activó al salir de la zona invisible.
        Debug.Log("Salio de la zona");
        dentro=false;
    }

    void SpawnPrefab()
    {
    // Instanciar el prefab en la posición y rotación deseadas
    taskPrefab.SetActive(true);

    
    }

    void RemoveObject(){
        taskPrefab.SetActive(false);
    }
   
}
