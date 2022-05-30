using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttomscript : MonoBehaviour
{
    public void LoadNewLevel1(string sceneName)
    {
        SceneManager.LoadScene("Scenes/wanted");
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
