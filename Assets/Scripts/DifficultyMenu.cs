using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DifficultyMenu : MonoBehaviour
{
    public void Hard()
    {
        SceneManager.LoadScene("Game10");
    }
    public void Normal()
    {
        SceneManager.LoadScene("Game5");
    }
    public void Easy()
    {
        SceneManager.LoadScene("Game3");
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
