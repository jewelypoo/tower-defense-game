using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
/*
 * Author: [Fain, Jewel ; Gibson,Hannah]
 * Last Updated: [12/08/2023]
 * [Handles lives on the main screen]
 */
public class LivesUI : MonoBehaviour
{



    public TMP_Text livesText;


    private void Update()
    {
        livesText.text = "Lives: " + PlayerStats.lives.ToString();
    }




}


