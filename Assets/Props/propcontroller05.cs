using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propcontroller05 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerStatusInfo psi = other.GetComponent<PlayerStatusInfo>();
        if (psi != null)
        {
            Destroy(this.gameObject);
            Debug.Log("拾取道具05");
            //启动player的道具05函数？
            prop05(psi);
        }
    }
    //04
    void prop05(PlayerStatusInfo psi)
    {
        Debug.Log("ATK:" + psi.Atk);
        Debug.Log("启动！");
        //启动计时器,30s
        psi.PropsTimer[5] = 1500;
        psi.Atk--;
        //每0.5s对周围敌人造成一次撞击伤害


        ///待完成
        Debug.Log("ATK:" + psi.Atk);
    }
}
