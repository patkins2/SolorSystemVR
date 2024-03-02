using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Pause : MonoBehaviour
{
    //public GameObject pause;
    public static bool gamePaused;
    public SteamVR_Action_Boolean ClickAction;
    public SteamVR_Input_Sources TargetSource;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gamePaused = !gamePaused;
            PauseGame();
        }
        if (ClickAction.GetStateDown(TargetSource))
        {
            Debug.Log("A pressed");
            gamePaused = !gamePaused;
            PauseGame();
        }
    }
    private void PauseGame()
    {
        if (gamePaused)
            Time.timeScale = 0f; //pause
        else
            Time.timeScale = 1; //unpause
    }
}
