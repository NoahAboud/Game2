using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainSceneManager : MonoBehaviour
{
    public GameObject blueWinUI;
    public GameObject redWinUI;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (redWinUI.activeInHierarchy)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        if (blueWinUI.activeInHierarchy)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }

    public void quit()
    {
        Application.Quit();
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
