using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{



    void Update()
    {
        if(PlayerStats.lives<= 0)
        {
            endGame();
        }

    }


    public void endGame()
    {
        SceneManager.LoadScene(2);
    }

}
