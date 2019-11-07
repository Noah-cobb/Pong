using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
public class SceneChange : MonoBehaviour
{
    // Start is called before the first frame update
    public string ChangeScene = "Level 1";

    public void LoadScene()
    {
        SceneManager.LoadScene(ChangeScene);

    }



    void Start()
    {
        




    }

    // Update is called once per frame
    void Update()
    {

    }
}