using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class PanelTask : MonoBehaviour
{

    public TextMeshProUGUI display;
    // Start is called before the first frame update
    private Password password1;
    //public GameObject pass;
    private string password;
    public GameObject gameover;

    public GameObject[] notes;

    private float delay=10f;
    

    void Start()
    {
        //password1=pass.GetComponent<Password>();

        int randomIndex= Random.Range(0, notes.Length);
        GameObject randomPassword= notes[randomIndex];
        password1=randomPassword.GetComponent<Password>();

    }
    

    public void AddNumber(string number){
        if(display.text.Length >=4){
            return;
        }
        display.text += number;
    }

    public void ClearDisplay(){
        display.text= "";
    }

    public void CheckPassowrd(){
       password= password1.randomValue.ToString();
       Debug.Log(password);
       if(display.text.Equals(password)){
        display.color=Color.green;
        display.text="Granted";
        Destroy(gameObject, 1.0f);
        gameover.SetActive(true);
        StartGameover();
       }else{
        display.text="Denied";
       }


    }


    private void StartGameover(){
     Invoke("BackMenu", delay);
    }

    private void BackMenu(){
         SceneManager.LoadScene("MainMenu");
    }

    

    
    
}