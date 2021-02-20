using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject  info;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void  closeCanvas(){
        info.SetActive(false);

    }
}
