using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holdin : MonoBehaviour
{
    public Transform myHand;
    public Rigidbody TheBall;
   

 
    // Start is called before the first frame update
    void Start()
    {
        TheBall.transform.parent = myHand.transform;
      
     
        
    }

}
