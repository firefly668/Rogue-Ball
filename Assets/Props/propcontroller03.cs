using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propcontroller03 : MonoBehaviour
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
            Debug.Log("拾取道具03");
            //启动player的道具03函数？
            prop03(psi);
        }
    }
    //03
    void prop03(PlayerStatusInfo psi)
    {
        Debug.Log("lightning:" + psi.Lightning);
        Debug.Log("启动！");
        //启动计时器,30s
        psi.PropsTimer[3] = 1500;
        //闪电buff
        psi.Lightning = true;
        Debug.Log("lightning:" + psi.Lightning);
    }
}
