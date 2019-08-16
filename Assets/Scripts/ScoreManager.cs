using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public int mana;
    public Image barImage;
    public Sprite[] bars;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        InvokeRepeating("Timer", 1, 1f);
    }

    public void Increase()
    {
        barImage.sprite = bars[mana / 10];
    }
    private void Timer()
    {
        mana += Click.amountPerSecond;
        Increase();
    }
}
