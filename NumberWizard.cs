using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;

    // Start is called before the first frame update
    void Start()
    {

        StartGame();
    }   

    void StartGame()
    {
        max = 1000;
        max = 1;
        guess = 500;

        Debug.Log("G'day mate, welcome to Number Wizard, you know what sounds really good? Maccas.");
        Debug.Log("Please pick a number! Any number! Make sure you don't accidentally say it out loud.");
        Debug.Log("The highest the number can be is: " + max);
        Debug.Log("The lowest the number can be is: " + min);
        Debug.Log("Tell me if your number is higher or lower than 500.I'm good at guessing!");
        Debug.Log("Push up = Higher, Push down = Lower, Enter = Correct");
        max = max + 1;

    }

    // Update is called once per frame
    void Update()
    {
        //Detect when the up arrow key is pressed down and the number is higher.
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
         
        }


        //Detect when the Down Arrow is pressed and the number is lower.
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
         
        }
        //Detect when Enter is pressed and the player has won.

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I won!");
            StartGame();
        }



    }
    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is it higher or lower than " + guess);
    
    }
}
