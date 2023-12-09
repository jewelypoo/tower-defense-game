using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/*
 * Author: [Fain, Jewel ; Gibson,Hannah]
 * Last Updated: [12/08/2023]
 * [Handles main menu scene to play or quit]
 */
public class EndScreen1 : MonoBehaviour
{
    /// <summary>
    /// allows player to quit game
    /// </summary>
    public void QuitGame()
    {
        Application.Quit();
    }
    /// <summary>
    /// switches scene to load the game
    /// </summary>
    /// <param name="sceneIndex"> allows scene to change</param>
    public void SwitchScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
