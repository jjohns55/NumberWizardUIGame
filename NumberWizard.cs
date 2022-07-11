using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        NextGuess();  
    }

    void NextGuess()
    {
        guess = Random.Range(min, max);
        guessText.text = guess.ToString();
    }

    public void OnPressHigher()
    {
        if(min != max)
        {
            min = guess + 1;
            NextGuess();
        }
        
    }

    public void OnPressLower()
    {
        if(max != min)
        {
            max = guess - 1;
            NextGuess();
        }
        
        
    }
}
