using UnityEngine;
using System.Collections;

public class StartScreen : MonoBehaviour
{

    void OnGUI()
    {
        GUI.Label(new Rect(25, 25, 100, 50), "Welcome to the Unity Lerpz Level!!");
        if (GUI.Button(new Rect(25, 75, 100, 30), "START"))
        {
            Application.LoadLevel("Level_1");
        }
        if (GUI.Button(new Rect(25, 75, 125, 30), "Exit"))
        {
            Application.Quit();
        }
    }
}
