using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class framescript : MonoBehaviour
{
    int nextscene = 10;
    public void OnTriggerEnter(int level)
    {
        SceneManager.LoadScene(nextscene);


    }
}
