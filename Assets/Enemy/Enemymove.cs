using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemymove : MonoBehaviour
{
    public float speed = 3f;

    private void Start()
    {
        
    }
    

    void Update()
    {
        //float x = 1f;
        //float y = 1f;
        float x = Random.Range(-1.5f, 1.5f);
        float y = Random.Range(-1.5f,1.5f);
        Vector3 newPos = transform.position + new Vector3(x, y, 0) * speed * Time.deltaTime;
        if (newPos.x < -19.28 || newPos.x > 19.28)
        {
            newPos.x = transform.position.x;
        }

        if (newPos.y < -9.0 || newPos.y > 9.0)
        {
            newPos.y = transform.position.y;
        }

        transform.position = newPos;
    }
}
