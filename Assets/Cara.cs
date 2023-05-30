using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cara : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth; //Å©Ç±Ç±
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector2 position = transform.position;
        position.x = position.x + 6.0f * horizontal * Time.deltaTime;
        position.y = position.y + 6.0f * vertical * Time.deltaTime;
        transform.position = position;
    }
    public void ChangeHealth(int amount) //Å©Ç±Ç±Ç©ÇÁ
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);
        UI.instance.SetValue(currentHealth / (float)maxHealth);
    }
}
