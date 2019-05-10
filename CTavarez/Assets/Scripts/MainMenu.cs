/* Clear A. Tavarez, 2019
 * Made with help from Brackeys: https://www.youtube.com/watch?v=zc8ac_qUXQY 
 * 
 * This script loads the appropriate scene when the linked button is pressed */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene("Tut1");

    }

    public void PlayGame2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);

    }

    public void PlayGame3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);

    }

}
