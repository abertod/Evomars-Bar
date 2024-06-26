﻿using UnityEngine;

namespace DialogueEditor
{
    /// <summary>
    /// This class holds all of the values for a node which 
    /// need to be serialized. 
    /// </summary>
    [System.Serializable]
    public class NodeEventHolder : MonoBehaviour
    {
        [SerializeField] public UnityEngine.Events.UnityEvent Event;

        [SerializeField] public int NodeID;
        [SerializeField] public TMPro.TMP_FontAsset TMPFont;
        [SerializeField] public Sprite Icon;

        [SerializeField] public Sprite Icon02;
        [SerializeField] public Sprite Icon03;
        [SerializeField] public Sprite Icon04;
        [SerializeField] public Sprite Icon05;

        
        [SerializeField] public AudioClip Audio;
    }
}