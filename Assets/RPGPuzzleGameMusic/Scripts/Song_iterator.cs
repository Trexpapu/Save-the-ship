using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Song_iterator : MonoBehaviour
{
   public AudioClip[] songs;   // Array que contiene las canciones
    private int currentSongIndex = 0;   // Índice de la canción actual
    private AudioSource audioSource;   // Referencia al componente AudioSource

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        // Reproducir la primera canción
        PlayCurrentSong();
    }

    void Update()
    {
        // Verificar si la canción actual ha terminado de reproducirse
        if (!audioSource.isPlaying)
        {
            // Pasar a la siguiente canción
            currentSongIndex++;
            if (currentSongIndex >= songs.Length)
            {
                currentSongIndex = 0;   // Volver a la primera canción si se llega al final del array
            }

            // Reproducir la canción actual
            PlayCurrentSong();
        }
    }

    void PlayCurrentSong()
    {
        audioSource.clip = songs[currentSongIndex];
        audioSource.Play();
    }
}
