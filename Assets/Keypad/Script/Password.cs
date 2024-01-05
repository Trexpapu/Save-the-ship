using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Password : MonoBehaviour
{
   public TextMeshProUGUI nota;

   public List<int> numberList;

    int randomIndex;
    public int randomValue;
   

   void Start()
   {
    GeneratePassword();
    SelectPassword();
   }

   private void GeneratePassword(){
    nota.text="";
    int[] array= new int [4];//arreglo para la contraseña
   
    for(int i=0; i<4; i++){//password tamaño del password
        int randomNumber= UnityEngine.Random.Range(1, 9);
        nota.text += randomNumber;
       array[i]=randomNumber;
    }
     for(int j=0; j<9; j++){//tamaño de la lista relacion con la cantidad de maquinas
    string combinedNumberString = string.Join("", nota.text);
    int combinedNumber = int.Parse(combinedNumberString);
    numberList.Add(combinedNumber);
   
   }
   }

   private void SelectPassword(){
    randomIndex = UnityEngine.Random.Range(0, 8);//index del tamaño de la lista de 0 a cantidad de maquinas-1
    Debug.Log(randomIndex);
    randomValue = numberList[randomIndex];
    Debug.Log("Número aleatorio: " + randomValue);
    Debug.Log("es " + numberList.Count);
    
    
   }

    
}