using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propcontroller02 : MonoBehaviour
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
            Debug.Log("拾取道具02");
            //启动player的道具01函数？
            prop02(psi);
        }
    }
    //02
    void prop02(PlayerStatusInfo psi)
    {
        Debug.Log("KILLRES:" + psi.Killres);
        Debug.Log("启动！");
        //击杀回血
        psi.Killres++;
        //启动计时器,30s
        psi.PropsTimer[2] = 1500;
        
        Debug.Log("KILLRES:" + psi.Killres);
    }
}
