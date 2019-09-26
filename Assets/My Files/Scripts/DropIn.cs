using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropIn : MonoBehaviour
{
    public GameObject TheBallAgain;
    public Transform YourNewHome;
    public GameObject placeholder;
    public GameObject particle;
  

    // Start is called before the first frame update
    void Start()
    {

        TheBallAgain.SetActive(false);

    }
    void Update()
    {
            dropin();
        if (TheBallAgain.transform.localPosition == YourNewHome.transform.localPosition)
        {
            particle.SetActive(true);
        }
    }
    public void dropin()
    {
        TheBallAgain.transform.parent = null;
        TheBallAgain.transform.localPosition = YourNewHome.transform.localPosition;
        TheBallAgain.transform.localRotation = YourNewHome.transform.localRotation;
        TheBallAgain.transform.localScale = YourNewHome.transform.localScale;
        TheBallAgain.SetActive(true);
    }
}
   

