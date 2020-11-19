using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void PlayGame()

    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    public void QuitGame() //koodi joka yhdistettiin main menuun, jotta Quit näppäin saataisiin toimimaan
    {
        Debug.Log("QUIT!");
        Application.Quit(); 
    }
}