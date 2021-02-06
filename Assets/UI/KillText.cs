using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class KillText : MonoBehaviour
{
    int KillNumber;
    int TargetNumber;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        KillNumber = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().KillNumber;
        TargetNumber = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().TargetNumber;
        this.GetComponent<Text>().text = KillNumber.ToString() + "/" +TargetNumber.ToString();
    }
}
