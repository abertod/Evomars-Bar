using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CHARACTERS
{
    public class Character_Text : Character
    {
        //Character with no graphical art, text operations only (bartender)
        public Character_Text(string name) : base(name)
        {
            Debug.Log($"Created Text Character: '{name}'");
        }
    }

}
