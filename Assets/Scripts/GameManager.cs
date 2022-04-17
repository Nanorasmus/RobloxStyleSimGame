using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    [SerializeField] private Text moneyText;
    [SerializeField] private float money;

    public float GetMoney()
    {
        return money;
    }

    public void AddMoney(float amount) 
    {
        money += amount;
        UpdateMoneyText();
    }

    public void RemoveMoney(float amount)
    {
        money -= amount;
        UpdateMoneyText();
    }

    private void UpdateMoneyText()
    {
        moneyText.text = money.ToString() + "$";
    }
}
