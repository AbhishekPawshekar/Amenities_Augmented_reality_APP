using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class chairscript: MonoBehaviour
{
    int nextscene=4;
    public void OnTriggerEnter(int level)
    {
        SceneManager.LoadScene(nextscene);


    }
}