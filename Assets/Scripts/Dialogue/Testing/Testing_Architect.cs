using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TESTING
{
    public class Testing_Architect : MonoBehaviour
    {
        DialogueSystem ds;
        TextArchitect architect;

        string[] lines = new string[5]
        {
            "This is a random line of dialogue",
            "I want to unalive myself",
            "I seriously need help, please",
            "Call the 911",
            "lol"
        };

        // Start is called before the first frame update
        void Start()
        {
            ds = DialogueSystem.instance;
            architect = new TextArchitect(ds.dialogueContainer.dialogueText);
            architect.buildMethod = TextArchitect.BuildMethod.typewriter;

        }

        // Update is called once per frame
        void Update()
        {
            string longLine = "This is a very long line that makes no sense but I am just populating it with stuff because, you know, fuck tanks, how can you have 5000 hp and still smash the fuck of everyone's asses out and still get no damage because you're a supposed tanky champion. I'm about to start a fire on riot games offices because there's nothing that makes sense in this reality. ";
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (architect.isBuilding)
                {
                    if (!architect.hurryUp)
                        architect.hurryUp = true;
                    else
                        architect.ForceComplete();
                }
                else
                    architect.Build(longLine);
                    //architect.Build(lines[Random.Range(0, lines.Length)]);
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                architect.Append(longLine);
                //architect.Append(lines[Random.Range(0, lines.Length)]);
            }
        }
    }

}
