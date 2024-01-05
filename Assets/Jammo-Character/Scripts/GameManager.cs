using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public float timeLimit = 480f; // Tiempo límite en segundos
    public float timer; // Tiempo actual del temporizador
    private bool isRunning; // Indicador de si el temporizador está en marcha
    public TextMeshProUGUI timertext;
    string numero;
    int entero;
    private float startDelay = 20f;    // Retraso antes de iniciar el temporizador (5 segundos)
    void Start()
    {
        
        timertext.text="";
        StartTheStart();
    }

    void Update()
    {
        if (isRunning)
        {
            timer -= Time.deltaTime;
            entero = Mathf.RoundToInt(timer);
            numero = entero.ToString();
            timertext.text = numero;
             

            if (timer <= 0f)
            {
                // El temporizador ha llegado a cero, detener el juego
                isRunning = false;
                Debug.Log("Tiempo agotado, juego detenido");
                StopGame();
            }
        }
    }

    public void StartTimer()
    {
        timer = timeLimit;
        isRunning = true;
    }

    private void StopGame()
    {
        // Detener el juego
         SceneManager.LoadScene("MainMenu");
        // Ten en cuenta que Application.Quit() no funciona en el editor de Unity, solo en el juego compilado
    }
    private void StartTheStart(){
        {
        Invoke("StartTimer", startDelay);
    }

    }


}
