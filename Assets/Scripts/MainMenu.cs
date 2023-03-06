using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void OpenMenu()
    {
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    public void CloseMenu()
    {
        Application.Quit();
    }
}
