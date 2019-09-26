using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonotDestroyAudio : MonoBehaviour
{
   void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
