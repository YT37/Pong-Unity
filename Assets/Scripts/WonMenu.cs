using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WonMenu : MonoBehaviour
{   public void RestartGame()
    {
        SceneManager.LoadScene("Difficulty");
    }
    public void MenuGame()
    {
        SceneManager.LoadScene("Menu");
    }
}
