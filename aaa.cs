using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class aaa : MonoBehaviour {


    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;

    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        
        Nextguess();
        
    }

    // Update is called once per frame

    void Nextguess()
    {
        guess = Random.Range(min, max+1);
        if (guess >= min && guess <= max)
        {
            guessText.text = guess.ToString();
        }

    }
    public void OnPressHigher()
    {
        min = guess + 1;
        Nextguess();
        
    }
    public void OnPressLower()
    {
        max = guess-1;
        Nextguess();
        
    }
}
