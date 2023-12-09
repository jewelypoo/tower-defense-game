using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
/*
 * Author: [Fain, Jewel ; Gibson,Hannah]
 * Last Updated: [12/08/2023]
 * [Handles the money on the game screen to display money available]
 */
public class MoneyUI : MonoBehaviour
{

    public TMP_Text moneyText;


    private void Update()
    {
        moneyText.text = "$" + PlayerStats.Money.ToString();
    }




}
