using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;//UIを使うときに書きます。

public class Player : MonoBehaviour
{
    public int maxHealth = 100; //←ここ
    public int currentHealth; //←ここ
    public GameObject projectilePrefab;
    Rigidbody2D rigidbody2d;
    void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }
    public void Start()
    {
        currentHealth = maxHealth; //←ここ
    }
    public void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical"); //←ここ

        Vector2 position = transform.position;
        position.x = position.x + 0.1f * horizontal;
        position.y = position.y + 0.1f * vertical; //←ここ
        transform.position = position;
        

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Launch();
        }

    }
    void Launch()
    {
        GameObject projectileObject = Instantiate(projectilePrefab, rigidbody2d.position + Vector2.up * 0.5f, Quaternion.identity);
        Projectile projectile = projectileObject.GetComponent<Projectile>();


    }
    public void ChangeHealth(int amount) //←ここから
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);
        UIHealthBar.instance.SetValue(currentHealth / (float)maxHealth);
        if (currentHealth == 0)
        {

            // オブジェクトを破壊する
            Destroy(transform.root.gameObject);
            if (transform.root.gameObject)
            {
                SceneManager.LoadScene("gameover");
            }
        }
    } //←ここまで

}