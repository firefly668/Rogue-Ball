using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginButton : MonoBehaviour
{
    public delegate void Begin();
    public event Begin begin;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other){
        if(other.tag=="Player"){
            begin();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
