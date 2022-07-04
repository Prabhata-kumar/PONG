using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenChange : MonoBehaviour
{
    public void MoveScreen(int ScrenID)
    {
        SceneManager.LoadScene(ScrenID);
    }

    public void Quit()
    {
        Application.Quit(); 
    }
}
