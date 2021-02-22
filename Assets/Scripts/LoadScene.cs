using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    //public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        //SceneManager.LoadScene("TestScene", LoadSceneMode.Single);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadScene1(string sceneName)
    {
        //Debug.Log("Attempting to print %s", sceneName);
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }
}
