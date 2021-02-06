using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public float hp;

    public float demage;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDemage(int demage)
    {
        hp -= demage;
        if (hp <= 0)
        {
            GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().KillNumber++;
            Destroy(gameObject);
        }
    }
}
