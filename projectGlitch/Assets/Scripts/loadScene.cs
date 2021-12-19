using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour
{

    public int scene; //scene to load
    //load next scene
    public void LoadScene(int level)
    {
        SceneManager.LoadScene(level);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            LoadScene(scene);
        }
    }
    //quit game
    public void exitGame()
    {
        Application.Quit();
    }
}
