using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diecter1 : MonoBehaviour
{
    public GameObject Enemy_0;
    float span = 0.90f;
    float delta = 0;

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta>this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(Enemy_0);
            int px =Random.Range(-15, 15);
            go.transform.position =new Vector3(30, px,0);
        }
    }
}
