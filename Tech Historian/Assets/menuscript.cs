using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuscript : MonoBehaviour
{
    public void toAR(){
        SceneManager.LoadScene("toAR");
    }

    public void exitButton(){
        Application.Quit();
        Debug.Log("Game Close");
    }

    public void aboutButton(){
        SceneManager.LoadScene("About");
    }
}