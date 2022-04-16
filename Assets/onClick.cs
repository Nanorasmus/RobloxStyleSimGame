using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClick : MonoBehaviour
{
    [SerializeField] private Text counterText;
    public GameObject LemonadeStandSellButton;
    public Slider SellSlider;

    private int LemonadeStandMoneyGain = 1;
    private int multiplier = 1;
    private int RebirthCounter = 0;

    public void LemonadeStandGain()
    {
        LemonadeStandSellButton.SetActive(false);
    }

    public void LemondeStandLose()
    {
        
    }
}
