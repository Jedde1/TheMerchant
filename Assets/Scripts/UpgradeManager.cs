using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    [Header("Upgrade buttons")]
    public GameObject[] clickValueUpgrade;

    [Header("Upgrade Prices")]
    public int[] clickValuePrices;

    [Header("Upgrade Amounts")]
    public int[] clickValueValue;

    private void Update()
    {
        for (int i = 0; i < clickValuePrices.Length; i++)
        {
            
            if (ScoreManager.Instance.mana >= clickValuePrices[i])
            {
                clickValueUpgrade[i].SetActive(true);
            }
            else
            {
                clickValueUpgrade[i].SetActive(false);
            }
        }
    }
    public void ClickValueUpgrade(int indexRef)
    {
        ScoreManager.Instance.mana -= clickValuePrices[indexRef];
        Click.clickValue += clickValueValue[indexRef];
        clickValuePrices[indexRef] += 25;
        ScoreManager.Instance.Increase();
    }
}
