using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Testing : MonoBehaviour
{
    
    private void Start()
    {
        
        FunctionTimer.Create(TestingAction, 60f); //Lataa scenen tietyn ajan päästä
    }

    private void TestingAction()
    {
        SceneManager.LoadScene("PäiväScene"); //Lataa päivä scenen
    }
}
