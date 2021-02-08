using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propcontroller01 : MonoBehaviour
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
        if(psi != null)
        {
            Destroy(this.gameObject);
            Debug.Log("拾取道具01");
            //启动player的道具01函数？
            prop01(psi);
        }
    }
    //01
    void prop01(PlayerStatusInfo psi)
    {
        Debug.Log("UATK00:" + psi.Uatk);
        Debug.Log("RES00:" + psi.Res);
        Debug.Log("启动！");
        //启动计时器,30s
        psi.PropsTimer[1] = 1500;
        //收到伤害提升
        psi.Uatk++;
        //每次撞击回血
        psi.Res++;
        Debug.Log("UATK01:" + psi.Uatk);
        Debug.Log("RES01:" + psi.Res);
    }
   

}
