using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* Author: Erin Scribner
 * 
 * Date: 6/30/2024
 * 
 * Description: If ESC is pressed, activate the pause menu
 * 
 * Public Functions: None
 * 
 * Other Scripts Needed: None
 */
public class S_OpenPause_Erin : MonoBehaviour
{
    [Tooltip("The pause screen to open")]
    public GameObject pauseScreen;

    bool isPaused = false;

    void Start() { }

   /*
    * When ESC is pressed, activate the pause screen
    */
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;

            if (isPaused)
            {
                pauseScreen.SetActive(isPaused);
            }
            else
            {
                pauseScreen.SetActive(isPaused);
                Time.timeScale = 1;
            }
        }
    }
}
