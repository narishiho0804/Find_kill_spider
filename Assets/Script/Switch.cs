using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Switch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Scene()
    {
        SceneManager.LoadScene("Sample 7");
    }
    public void Exit()
    {
        //UnityEditor.EditorApplication.isPlaying = false; 
        Application.Quit();
    }
}
