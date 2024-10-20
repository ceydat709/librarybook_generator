using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 
using TMPro;

public class MainMenu : MonoBehaviour
{

    public void ChangeScene() 
    {
        //load main screen
        SceneManager.LoadSceneAsync("Scenes/MainScreen");
    }
 }


