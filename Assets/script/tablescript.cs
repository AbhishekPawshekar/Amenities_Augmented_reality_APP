﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class tablescript : MonoBehaviour
{
    int nextscene = 12;
    public void OnTriggerEnter(int level)
    {
        SceneManager.LoadScene(nextscene);


    }
}
