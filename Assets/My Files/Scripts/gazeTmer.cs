using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gazeTmer : MonoBehaviour
{
    public float MyTime = 0f;
    public Transform RadialProgress;

    public GameObject TheStufftodo;
    


    // Start is called before the first frame update
    void Start()
    {
        RadialProgress.GetComponent<Image>().fillAmount = MyTime;
        Vector3 ballPosition = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        MyTime += Time.deltaTime;
        RadialProgress.GetComponent<Image>().fillAmount = MyTime;
        if (MyTime >= 2f)
        {
            DoStuff();
        }
    }

    public void Resetinator()
    {
        MyTime = 0f;
        RadialProgress.GetComponent<Image>().fillAmount = MyTime;
    }
    public void DoStuff()
    {
        TheStufftodo.SetActive(true);
    }
}
