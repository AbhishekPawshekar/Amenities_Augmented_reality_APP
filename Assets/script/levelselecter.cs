using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelselecter : MonoBehaviour
{
    public Button d3button, interiorbutton, furniturebutton,chair1,sofa1;
    int levelPassed;
    void Start()
    {
        levelPassed = PlayerPrefs.GetInt("levelpassed");
  

        switch (levelPassed)
        {
            case 1:
                d3button.interactable = true;
                break;
            case 2:
                interiorbutton.interactable = true;
                break;
            case 3:
             furniturebutton.interactable = true;
                break;
            case 4:
                chair1.interactable = true;
                break;
            case 5:
               sofa1.interactable = true;
                break;

        }
    }

    public void levelToLoad(int level)
    {
        SceneManager.LoadScene(level);
    }


}
