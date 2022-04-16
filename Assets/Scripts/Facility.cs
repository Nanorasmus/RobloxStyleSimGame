using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Facility : MonoBehaviour
{
    public float facilitySellDuration = 3f;
    public float facilityBaseProfit = 1f;

    [SerializeField] private GameObject facilitySellButton;
    [SerializeField] private Slider sellSlider;
    [SerializeField] private GameManager gm;
    [SerializeField] private Text facilityUpgradePriceText;
    [SerializeField] private Text facilitySellPriceText;

    private float facilityProfit;
    private int facilityLevel = 1;
    private float sellTimer;
    private float facilityUpgradePrice = 20;

    private void Start()
    {
        sellTimer = facilitySellDuration;
        facilityProfit = facilityBaseProfit;
    }

    private void Update()
    {
        if(sellTimer < facilitySellDuration)
        {
            sellTimer += Time.deltaTime;

            sellSlider.value = sellTimer / facilitySellDuration;

            if(sellTimer >= facilitySellDuration)
            {
                gm.AddMoney(facilityProfit);
                sellSlider.value = 0;
                facilitySellButton.SetActive(true);
            }
        }
    }

    public void FacilityGain()
    {
        facilitySellButton.SetActive(false);
        sellTimer = 0;
    }

    public void FacilityUpgrade()
    {
       if(gm.GetMoney() < facilityUpgradePrice)
        {
            Debug.Log("You don't have enough money to buy this upgrade!");
        } else
        {
            gm.RemoveMoney(facilityUpgradePrice);
            facilityLevel += 1;
            facilityProfit *= 2;
            facilityUpgradePrice *= 2;
            facilityUpgradePriceText.text = facilityUpgradePrice.ToString() + "$";
            facilitySellPriceText.text = facilityProfit.ToString() + "$";
        }
    }
}
