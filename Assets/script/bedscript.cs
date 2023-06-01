using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class bedscript: MonoBehaviour
{
    int nextscene = 7;
    public void OnTriggerEnter(int level)
    {
        SceneManager.LoadScene(nextscene);


    }
}
