using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Click : MonoBehaviour
{
    public static int clickValue;
    public static int amountPerSecond;
    //public Animator ani;
    public void Start()
    {
        clickValue = 1;

        //ani = GetComponent<Animator>();
    }
    
    public void ClickerButton()
    {
        ScoreManager.Instance.mana += clickValue;
        ScoreManager.Instance.Increase();
    }

}
