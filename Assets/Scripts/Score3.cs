using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Score3 : MonoBehaviour
{
    void Update()
    {
        var textUIComp1 = GameObject.Find("LeftScore")
          .GetComponent<Text>();
        int LeftScore = int.Parse(textUIComp1.text);
        var textUIComp2 = GameObject.Find("RightScore")
         .GetComponent<Text>();
        int RightScore = int.Parse(textUIComp2.text);
        if(RightScore == 3 & LeftScore < RightScore)
        {
            SceneManager.LoadScene("YouLost");
        }
        else if (LeftScore == 3 & LeftScore > RightScore)
        {
            SceneManager.LoadScene("YouWon");
        }
        else
        {
        }
    }
}
