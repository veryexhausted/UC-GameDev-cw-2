using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    int score = 0;
    int inc = 1;
    public int price;
    public Text scoreText;
    public Text incText;
    public Text priceText;

    public Text errorText;

    public void IncreaseScore()
    {
        score += inc;
        scoreText.text = score.ToString();
    }

    public void Shop()
    {
        if (score > price * inc)
        {
            score -= price * inc;
            scoreText.text = score.ToString();
            inc += 1;
            incText.text = "Inc: " + inc;
            priceText.text = "Price= " + (price * inc);
            errorText.text = " ";
        }
        else
        {
            errorText.text = "You don't have enough score points!";

        }
    }
}
