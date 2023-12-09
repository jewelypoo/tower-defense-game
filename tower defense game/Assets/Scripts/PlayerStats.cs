using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static int Money;
    public int startMoney = 300;

    public static int lives;
    public int startLives = 5;

    public void Start()
    {
        Money = startMoney;
        lives = startLives;


    }



}
