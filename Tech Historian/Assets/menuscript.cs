using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuscript : MonoBehaviour
{
    public void toAR(){
        SceneManager.LoadScene("AR");
    }

    public void exitButton(){
        Application.Quit();
        Debug.Log("Game Close");
    }

    public void aboutButton(){
        SceneManager.LoadScene("About");
    }

    
}
