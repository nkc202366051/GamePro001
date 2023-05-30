using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class UI : MonoBehaviour
{

    public Image UIobj;
    public bool roop;
    public float countTime = 5.0f;
    public static UI instance
    {
        get;
        private set;
    }

    
    float originalSize;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        originalSize = UIobj.rectTransform.rect.width;
    }

    public void SetValue(float value)
    {
        UIobj.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, originalSize * value);
    }


    public void Update()
    {
        if (roop)
        {
            UIobj.fillAmount -= 1.0f / countTime * Time.deltaTime;

        }
    }
}
