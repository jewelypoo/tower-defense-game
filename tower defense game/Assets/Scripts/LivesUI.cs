using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LivesUI : MonoBehaviour
{



    public TMP_Text livesText;


    private void Update()
    {
        livesText.text = "Lives: " + PlayerStats.lives.ToString();
    }




}


