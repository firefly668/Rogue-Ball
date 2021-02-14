using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyProducer : MonoBehaviour
{
    public GameObject Enemy;
	//空对象
	public GameObject ParentEnemy;
	//敌人的最大数量
	public int maxcount = 3;

	//生成敌人的延迟时间
    public float maxTime = 1.5f;
	
	//当前关卡的生成的总敌人数，需要设定
	public int totalcount = 10;

	//计数器
	public int count = 0 ;

	public int enemyNum;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateEnemy", 1, maxTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CreateEnemy(){
		enemyNum = ParentEnemy.transform.childCount;
		if(enemyNum < maxcount && count < totalcount){
			GameObject EnemyObj = Instantiate(Enemy, new Vector3(Random.Range(-10.0f, 5.0f), Random.Range(-10.0f, 5.0f)), Quaternion.identity);
            EnemyObj.transform.parent = ParentEnemy.transform;
			count ++;
		}
	}

}
