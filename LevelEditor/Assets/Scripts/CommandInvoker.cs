﻿//Code refrenced from Youtube: Board to Bits
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandInvoker : MonoBehaviour
{
    static Queue<ICommand> commandBuffer;
    static List<ICommand> commandHistory;
    static int counter; 

    private void Awake()
    {
        commandBuffer = new Queue<ICommand>();
        commandHistory = new List<ICommand>();
    }

    public static void AddCommand (ICommand command)
    {
        commandBuffer.Enqueue(command);
            while(commandHistory.Count>counter)
            {
                commandHistory.RemoveAt(counter);
            }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (commandBuffer.Count > 0)
        {
            ICommand c = commandBuffer.Dequeue();
            c.Execute();

            //commandBuffer.Dequeue().Execute();
            commandHistory.Add(c);
            counter++;
            Debug.Log("Command History length: " + commandHistory.Count);
        }

        else
        {
            if(Input.GetKeyDown(KeyCode.Z))
            {
                if (counter > 0)
                {
                    counter--;
                    commandHistory[counter].Undo();
                }
            }
              else if (Input.GetKeyDown(KeyCode.R))
                {
                    if (counter < commandHistory.Count)
                    {
                        commandHistory[counter].Execute();
                        counter++;
                    }
                }
        }
    }
}
