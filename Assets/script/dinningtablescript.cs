using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class dinningtablescript : MonoBehaviour
{
    int nextscene = 9;
    public void OnTriggerEnter(int level)
    {
        SceneManager.LoadScene(nextscene);


    }
}
