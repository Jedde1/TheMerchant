using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacks : MonoBehaviour
{
    [Header("Attack buttons")]
    public GameObject[] attacks;

    [Header("Attack Prices")]
    public int[] attackValuePrices;

    [Header("Attack amount")]
    public int[] attackValueValue;

    private void Update()
    {
        for (int i = 0; i < attackValuePrices.Length; i++)
        {

            if (ScoreManager.Instance.mana >= attackValuePrices[i])
            {
                attacks[i].SetActive(true);
            }
            else
            {
                attacks[i].SetActive(false);
            }
        }
    }
    public void attacksValueUpgrade(int indexRef)
    {
        ScoreManager.Instance.mana -= attackValuePrices[indexRef];
        Click.clickValue += attackValueValue[indexRef];
        //attackValuePrices[indexRef] += (int)attackValuePrices[indexRef] / 3;
        ScoreManager.Instance.Increase();
    }
}
