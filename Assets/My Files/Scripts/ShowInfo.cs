using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInfo : MonoBehaviour
{
   
    public GameObject CustomImage;
    

    void Start()
    {
        CustomImage.SetActive(false);
    }
    public void Show()
    {
        CustomImage.SetActive(true);
        

    }
  
}
