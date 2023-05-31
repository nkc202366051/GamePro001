using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;//UIを使うときに書きます。
using static UnityEngine.GraphicsBuffer;

public class Boos : MonoBehaviour
{
    private float time;
    private bool turnBool = false;
    float rotSpeed = 0;
    public GameObject target;
    private Animator animator;
    public int maxHealth = 1000000; //←ここ
    public int currentHealth; //←ここ
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        currentHealth = maxHealth; //←ここ
    animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth < 1801)
        {
            if (!turnBool)

                time -= Time.deltaTime;
            if (time <= 0.0f)
            {
                turnBool = true;

                time -= Time.deltaTime;
                time = 3.0f;
                this.rotSpeed = Random.Range(50, 300);
            }
        }
        transform.Rotate(0, 0, this.rotSpeed);
        this.rotSpeed *= 0.86f;

        if (currentHealth < 1801)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, 0.1f);



            time -= Time.deltaTime;
            if (time <= 0.0f)
            {
                this.rotSpeed = Random.Range(50, 150);
                time -= Time.deltaTime;
                time = 10.0f;

            }
        }
    }
    
    public void ChangeHealth(int amount) //←ここから
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);
        UIHealthBar1.instance.SetValue(currentHealth / (float)maxHealth);
        if(currentHealth < 1800) 
        {
            animator.SetBool("Hensin", true);
            
        }
        if (currentHealth == 0)
        {

            // オブジェクトを破壊する
            Destroy(transform.root.gameObject);
        }
    }
}
