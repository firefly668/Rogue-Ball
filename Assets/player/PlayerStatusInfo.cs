using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatusInfo : MonoBehaviour
{
    public int MaxHp;
    public int Hp;
    public int Melee;
    // Start is called before the first frame update
    void Start()
    {
        Hp = MaxHp;
    }

    // Update is called once per frame
    void Update()
    {
        
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
}
