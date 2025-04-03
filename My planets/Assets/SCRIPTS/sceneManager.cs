using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{


    public void LoadScene()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitApplication()
    {
        Application.Quit();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
