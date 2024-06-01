using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypewriterAudioManager : MonoBehaviour
{
   public List<AudioSource> audioSources; // Lista de AudioSources para efectos de sonido
    public List<AudioClip> typingSounds; // Lista de AudioClips para los sonidos de tipeo

    // Método para reproducir un efecto de sonido desde el efecto typewriter
    public void PlayTypingSound()
    {
        if (typingSounds != null && typingSounds.Count > 0 && audioSources != null && audioSources.Count > 0)
        {
            // Selecciona un AudioClip aleatorio de la lista
            AudioClip clip = typingSounds[Random.Range(0, typingSounds.Count)];
            
            foreach (var audioSource in audioSources)
            {
                if (!audioSource.isPlaying)
                {
                    audioSource.PlayOneShot(clip);
                    return;
                }
            }

            // Si todas las AudioSources están ocupadas, usa la primera
            audioSources[0].PlayOneShot(clip);
        }
    }
}
