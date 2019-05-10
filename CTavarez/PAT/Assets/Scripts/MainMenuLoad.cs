/* Clear A. Tavarez, 2019
 *
 * This script loads the main menu at startup and whenever a linked button is pressed */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuLoad : MonoBehaviour {

	void Start () {
        SceneManager.LoadScene("Main Menu");
	}
	
}
