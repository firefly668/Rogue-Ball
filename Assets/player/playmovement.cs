using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class playmovement : MonoBehaviour
{
    bool draw = false;
    bool gyinfo;
    private Gyroscope go;
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        gyinfo = SystemInfo.supportsGyroscope;
        go = Input.gyro;
        go.enabled = true;
        rb2d = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (gyinfo)
        {
            if(rb2d.velocity.magnitude<=4){
                float X = (float)Math.Round(go.attitude.x,3);
                float Y = (float)Math.Round(go.attitude.y,3);
                Vector2 a = new Vector2(X*25,Y*25);
                rb2d.AddForce(a);
            }
            draw = false;

        }
        else
        {
            draw = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="enemy")
        {
            other.GetComponent<Enemy>().TakeDemage(5);
        }
    }
    void Update()
    {
        int movespeed = 5;
        float x = Input.GetAxis("Vertical");
        float y = Input.GetAxis("Horizontal");
        Vector3 v = new Vector3(y,x,0);
        this.transform.Translate(v*Time.deltaTime*movespeed);
    }
    void OnGUI()
    {
        if (draw)
        {
            GUI.Label(new Rect(100, 100, 100, 30), "启动失败");
        }
        else{
            string Magnitude = rb2d.velocity.magnitude.ToString();
            GUI.Label(new Rect(200, 100, 100, 100), Magnitude);
            string X = Math.Round(go.attitude.x,3).ToString();
            GUI.Label(new Rect(100, 100, 100, 100), X);
            string Y = Math.Round(go.attitude.y,3).ToString();
            GUI.Label(new Rect(100, 200, 100, 100), Y);
            string Z = Math.Round(go.attitude.z,3).ToString();
            GUI.Label(new Rect(100, 300, 100, 100), Z);
            string W = Math.Round(go.attitude.w,3).ToString();
            GUI.Label(new Rect(100, 400, 100, 100), W);
        }
    }
}
