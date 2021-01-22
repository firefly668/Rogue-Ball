using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProductButton : MonoBehaviour
{
    public delegate void EnemyProduct();
    public event EnemyProduct EP;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="Player")
        {
           EP();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
