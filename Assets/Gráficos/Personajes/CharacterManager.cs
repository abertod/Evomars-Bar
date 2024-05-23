using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CHARACTERS
{
    public class CharacterManager : MonoBehaviour
    {
        public static CharacterManager instance {get; private set; }
        private Dictionary<string, Character> characters = new Dictionary<string, Character>();
        private void Awake ()
        {
        instance = this;
        }
        
        public Character CreateCharacter(string characterName)
        {
            if (characters.ContainsKey(characterName.ToLower()))
            {
                Debug.LogWarning($"A Character called '{characterName}' already exists. Did not create the character.");
                return null;

            }

            return null;
        }
    }
}
