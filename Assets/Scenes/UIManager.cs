using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    public GameObject healthbright;
    public GameObject healthdark;
    public GameObject healthframe;
    public Canvas canvas;
    public bool healthflag = false;
    private PlayerStatusInfo playerstatus;
    private void Awake(){
    }
    // Start is called before the first frame update
    void Start(){
        //healthbright;
        GameObject.Find("GameManager").GetComponent<GameManager>().begin += ShowHealth;
    }
    private void ShowHealth(){
        Canvas ca = Instantiate(canvas,new Vector3(0f,0f,-0.1f),new Quaternion(0,0,0,0));
        healthdark = ca.transform.GetChild(0).gameObject;
        healthbright = ca.transform.GetChild(1).gameObject;
        healthframe = ca.transform.GetChild(2).gameObject;
        playerstatus = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStatusInfo>();
        healthflag = true;
    }
    // Update is called once per frame
    void Update()
    {
        //healthbright.GetComponent<Image>().fillAmount = playerstatus.Hp / playerstatus.MaxHp;
        if(healthflag){
            healthbright.GetComponent<Image>().fillAmount = (float)playerstatus.Hp / (float)playerstatus.MaxHp;
            if(healthdark.GetComponent<Image>().fillAmount > healthbright.GetComponent<Image>().fillAmount){
                healthdark.GetComponent<Image>().fillAmount -= 0.003f;
            }
            else {
                healthdark.GetComponent<Image>().fillAmount = healthbright.GetComponent<Image>().fillAmount;
            }
        }
    }
}
