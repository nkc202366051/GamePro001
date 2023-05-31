using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;


public class Enemy : MonoBehaviour
{
    public GameObject target;
    public int maxHealth = 5;
    public int currentHealth; //←ここ
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        position.x = position.x + -0.01f;
        transform.position = position;
   
    }

    public void ChangeHealth(int amount) //←ここから
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);
        if (currentHealth == 0)
        {
            
            // オブジェクトを破壊する
            Destroy(transform.root.gameObject);

        }
    }
}
