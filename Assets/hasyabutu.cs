using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hasyabutu : MonoBehaviour
{
    public int maxHealth = 100; //������
    public int currentHealth; //������

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth; //������
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        position.x = position.x + 0.1f;
        transform.position = position;
    }
    public void ChangeHealth(int amount) //����������
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);
        if (currentHealth == 0)
        {

            // �I�u�W�F�N�g��j�󂷂�
            Destroy(transform.root.gameObject);
        }
    }
}
