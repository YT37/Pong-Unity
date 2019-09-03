using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Difficulty");
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
  
}
