using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propcontroller04 : MonoBehaviour
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
            Debug.Log("拾取道具04");
            //启动player的道具04函数？
            prop04(psi);
        }
    }
    //04
    void prop04(PlayerStatusInfo psi)
    {
        Debug.Log("fire:" + psi.Fire);
        Debug.Log("启动！");
        //启动计时器,30s
        psi.PropsTimer[4] = 1500;
        //火焰buff
        psi.Fire = true;
        Debug.Log("fire:" + psi.Fire);
    }
}
