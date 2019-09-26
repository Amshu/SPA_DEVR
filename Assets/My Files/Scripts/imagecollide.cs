using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class imagecollide : MonoBehaviour
{
    public GameObject placeholders;
    public string tag;
    

  

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(tag))
        {
            gameObject.transform.parent = null;
            gameObject.transform.localPosition = placeholders.transform.localPosition;
            gameObject.transform.localRotation = placeholders.transform.localRotation;
            gameObject.transform.localScale = placeholders.transform.localScale;
            Destroy(placeholders);
           
        }
      
    }
    
    
}
