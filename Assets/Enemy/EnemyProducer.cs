using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyProducer : MonoBehaviour
{
    public GameObject Enemy;

    //敌人的最大数量
    public int maxcount = 3;
    
    //当前的敌人数量
    public int realcount;

    //当前的敌人数目
    public int startcount = 3;

    //生成敌人的延迟时间
    public float maxTime = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < startcount; i++)
        {
            GenerateEnemy();
        }

        StartCoroutine(Logic());
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GenerateEnemy()
    {
        if (realcount < maxcount)
        {
            Invoke("CreateEnemy", Random.Range(0, maxTime));
            realcount++;
        }
    }

    public void CreateEnemy()
    {
        Instantiate(Enemy, new Vector3(Random.Range(-10.0f, 5.0f), Random.Range(-10.0f, 5.0f)), Quaternion.identity);
    }

    IEnumerator Logic()
    {
        while (true)
        {
            if (realcount < maxcount)
            {
                Instantiate(Enemy, new Vector3(Random.Range(-10.0f, 5.0f), Random.Range(-10.0f, 5.0f)), Quaternion.identity);
                realcount++;
            }
            yield return new WaitForSeconds(maxTime);
        }
    }
}
