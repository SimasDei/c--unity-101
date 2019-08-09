using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    int min = 1;
    int guess = 500;
    int max = 1000;

    // Start is called before the first frame update
    void Start()
    {
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
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up arrow key was pressed.");
            min = guess;
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down arrow key was pressed.");
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Return arrow key was pressed.");
        }

    }
}
