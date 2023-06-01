using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class sofascript: MonoBehaviour
{
    int nextscene = 5;
    public void ontriggerenter(int level)
    {
        SceneManager.LoadScene(nextscene);
    }
}
