using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int max = 1000;
        int min = 1;
        string title = "Number Wizard";

        Debug.Log("Welcome to " + title);
        Debug.Log("Pick a secret number");
        Debug.Log("The highest can be " + max);
        Debug.Log("Lowest: " + min);
        Debug.Log("I'm gonna make a guess, tell me if the number is higher or lower");
        Debug.Log("Push up: Higher!, Push Down: lower, Push ENTER: Correct!");
    }

    // Update is called once per frame
    void Update()
    {
        if (input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up arrow key was pressed.");
        }
    }
}
