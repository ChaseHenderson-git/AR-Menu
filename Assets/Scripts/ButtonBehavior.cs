using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBehavior : MonoBehaviour
{
    public GameObject primary;
    public GameObject secondary;

    public void ChangeWindow()
    {

        if (primary.activeInHierarchy == true)
        {
            primary.SetActive(false);
        }
        else if (secondary.activeInHierarchy == true)
        {
            secondary.SetActive(false);
            primary.SetActive(true);
        }
        else
        {
            primary.SetActive(true);
        }
    }
}
