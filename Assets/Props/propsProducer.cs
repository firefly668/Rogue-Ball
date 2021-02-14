using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propsProducer : MonoBehaviour
{
    public GameObject prop01;
    public GameObject prop02;
    public GameObject prop03;
    public GameObject prop04;
    public GameObject prop05;
    //propcontroller01 pc01;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void createProp(int num, Vector2 position)
    {
        switch (num)
        {
            case 1:
                createProp01(position);
                break;
            case 2:
                createProp02(position);
                break;
            case 3:
                createProp03(position);
                break;
            case 4:
                createProp04(position);
                break;
            case 5:
                createProp05(position);
                break;

        }
    }
    public void createProp01(Vector2 position)
    {
        Instantiate(prop01, position, Quaternion.identity);
    }
    public void createProp02(Vector2 position)
    {
        Instantiate(prop02, position, Quaternion.identity);
    }
    public void createProp03(Vector2 position)
    {
        Instantiate(prop03, position, Quaternion.identity);
    }
    public void createProp04(Vector2 position)
    {
        Instantiate(prop04, position, Quaternion.identity);
    }
    public void createProp05(Vector2 position)
    {
        Instantiate(prop05, position, Quaternion.identity);
    }
}
