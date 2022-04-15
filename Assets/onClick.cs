using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onClick : MonoBehaviour
{
    [SerializeField] private Text counterText;

    private int counter = 0;
    private int multiplier = 1;
    private int RebirthCounter = 0;

    public void AddMoney()
    {
        counter += multiplier;
        counterText.text = counter.ToString();
        Debug.Log(counter);
    }

    public void LoseMoney()
    {
        int price = multiplier * 20;
        if (counter < price)
        {
            Debug.Log("You don't have enough money! You need: " + price);
        } else
        {
            counter -= price;
            multiplier *= 2;
            Debug.Log(counter);
            Debug.Log("Your new multiplier is: " + multiplier);
            Debug.Log("You just paid: " + price);
            counterText.text = counter.ToString();
        }
    }

    public void Rebirth()
    {
        counter = 0;
        multiplier = 1;
        RebirthCounter++;
        Debug.Log("You rebirthed! Your total rebirths are: " + RebirthCounter);
        counterText.text = counter.ToString();
    }
}
