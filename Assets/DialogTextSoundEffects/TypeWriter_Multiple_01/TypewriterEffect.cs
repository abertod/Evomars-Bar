using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TypewriterEffect : MonoBehaviour
{
    public TextMeshProUGUI textComponent; // Usa TextMeshProUGUI si estás usando TextMeshPro
    public TypewriterAudioManager typewriterAudioManager; // Referencia al TypewriterAudioManager
    public string fullText; // El texto completo que quieres mostrar
    public float delay = 0.1f; // El retraso entre cada letra

    private string currentText = "";

    void Start()
    {
        StartCoroutine(ShowText());
    }

    IEnumerator ShowText()
    {
        for (int i = 0; i < fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i + 1);
            textComponent.text = currentText;

            if (typewriterAudioManager != null)
            {
                typewriterAudioManager.PlayTypingSound();
            }
            yield return new WaitForSeconds(delay);
        }
    }
}