using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatusInfo : MonoBehaviour
{
    public int MaxHp;
    public int Hp;
    public int Melee;

    //道具部分
    private int ATK;    //攻击力
    private int UATK;    //每次撞击受到的伤害
    private int RES;    //恢复力（每次撞击回复的血量）
    private int KILLRES;    //击杀敌人回复的血量
    private bool lightning;  //是否能够施加闪电buff
    private bool fire;   //是否能施加火焰buff
    private int[] propsTimer;  //道具计时器
    public propsProducer propsproducer; //道具生成器

    // Start is called before the first frame update
    void Start()
    {
        Hp = MaxHp;

        //道具
        ATK = 2;
        UATK = 1;
        RES = 0;
        KILLRES = 0;
        lightning = false;
        fire = false;

        //道具持续时间为3000*0.02s=1min
        propsTimer = new int[50];
        //道具生成器
        propsproducer = gameObject.GetComponent<propsProducer>();
    }

    // Update is called once per frame
    void Update()
    {

        //测试生成道具接口,参数：编号、位置
        if (Input.GetKeyDown(KeyCode.Z))
        {
            propsproducer.createProp(1, new Vector2(Random.Range(-10.0f, 5.0f), Random.Range(-10.0f, 5.0f)));
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            propsproducer.createProp(2, new Vector2(Random.Range(-10.0f, 5.0f), Random.Range(-10.0f, 5.0f)));
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            propsproducer.createProp(3, new Vector2(Random.Range(-10.0f, 5.0f), Random.Range(-10.0f, 5.0f)));
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            propsproducer.createProp(4, new Vector2(Random.Range(-10.0f, 5.0f), Random.Range(-10.0f, 5.0f)));
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            propsproducer.createProp(5, new Vector2(Random.Range(-10.0f, 5.0f), Random.Range(-10.0f, 5.0f)));
        }
    }
      private void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.tag=="attack"){
            Damage(20);
        }
    }
    public void Damage(int damage){
        if(Hp > damage){
            Hp -= damage;
        }
        else{
            Hp = 0;
            //Death();
        }
    }

    //道具
    void FixedUpdate()
    {
        //道具定时器（持续时间30s）
        for (int i = 1; i < 30; i++)
        {
            if (propsTimer[i] > 1)
            {
                propsTimer[i]--;
            }
            else if (propsTimer[i] == 1)
            {
                propsTimer[i]--;
                Debug.Log("道具" + i + "时间结束");
                deleteProps(i);
            }
        }

    }
    //解除道具效果
    void deleteProps(int i)
    {
        switch (i)
        {
            case 1:
                this.UATK--;
                this.RES--;
                Debug.Log("UATK02:" + this.UATK);
                Debug.Log("RES02:" + this.RES);
                break;
            case 2:
                this.KILLRES--;
                break;
            case 3:
                this.lightning = false;
                break;
            case 4:
                this.fire = false;
                break;
            case 5:
                this.ATK++;
                break;
        }
    }


    //getter&setter
    public int Atk { get => ATK; set => ATK = value; }
    public int Uatk { get => UATK; set => UATK = value; }
    public int Res { get => RES; set => RES = value; }
    public int Killres { get => KILLRES; set => KILLRES = value; }
    public bool Lightning { get => lightning; set => lightning = value; }
    public bool Fire { get => fire; set => fire = value; }
    //public int Killres { get => KILLRES; set => KILLRES = value; }
    public int[] PropsTimer { get => propsTimer; set => propsTimer = value; }
}
