using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;//UI���g���Ƃ��ɏ����܂��B

public class Player : MonoBehaviour
{
    public int maxHealth = 100; //������
    public int currentHealth; //������
    public GameObject projectilePrefab;
    Rigidbody2D rigidbody2d;
    void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }
    public void Start()
    {
        currentHealth = maxHealth; //������
    }
    public void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical"); //������

        Vector2 position = transform.position;
        position.x = position.x + 0.1f * horizontal;
        position.y = position.y + 0.1f * vertical; //������
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
    public void ChangeHealth(int amount) //����������
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);
        UIHealthBar.instance.SetValue(currentHealth / (float)maxHealth);
        if (currentHealth == 0)
        {

            // �I�u�W�F�N�g��j�󂷂�
            Destroy(transform.root.gameObject);
            if (transform.root.gameObject)
            {
                SceneManager.LoadScene("gameover");
            }
        }
    } //�������܂�

}