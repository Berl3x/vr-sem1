using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Testobj;
    public void Deactve()
    {
        if (Testobj.activeSelf == true)
        {
            Testobj.SetActive(false);
        }
        else
        {
            Testobj.SetActive(true);
        }
    }

}
