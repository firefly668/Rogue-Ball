using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject BeginButton;
    public bool initial = true;
    public delegate void Begin();
    public event Begin begin;
    // Start is called before the first frame update
    private void Awake(){
        Instantiate(player,new Vector3(0,0,-0.1f),new Quaternion(0,0,0,0));
        Instantiate(BeginButton,new Vector3(-2,-2,-0.1f),new Quaternion(0,0,0,0));
    }
    void Start()
    {
        GameObject.FindGameObjectWithTag("BeginButton").GetComponent<BeginButton>().begin += HandleBegin;
    }
    private void HandleBegin(){
        begin();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
