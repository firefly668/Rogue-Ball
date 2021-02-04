using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyProducer : MonoBehaviour
{
    public GameObject Enemy;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("EnemyProductButton").GetComponent<EnemyProductButton>().EP += Product;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Product(){
        int x = Random.Range(-5,5);
        int y = Random.Range(-5,5);
        Vector3 position = new Vector3(x,y,0);
        Instantiate(Enemy,position,transform.rotation);
    }
}
