using UnityEngine;

public class helloworld : MonoBehaviour {

    // Use this for initialization

    int max;
    int min;
    int guess;

    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        print("Welcome to number wizard console.");
        print("Pick a number and don't tell me what it is");
        print("The highest number you can pick is " + max);
        print("The lowest number you can pick is " + min);
        print("Tell me if your number is higher or lower then " + guess);
        print("Push up - Higher Push down - Lower Enter - Correct");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            Nextguess();
        }

        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            Nextguess();
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Correct!");
            StartGame();
        }

    } 

    void Nextguess()
    {
        guess = (min + max) / 2;
        Debug.Log("Guess is Higher or Lower than " + guess);
    }
    
}
