using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public Text[] text; // массив из текстов

    private TextMeshProUGUI textMesh;
    private int index;
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>(); // присваеваем компанент <TextMeshProUGUI>
    }
    public void Change()
    {
        if (index < text.Length) // прибавляем индекс, если он меньше длинны массива
        {
            index += 1;
        }
        
        for (int i = 0; i < text.Length; i++) // задаем цикл for
        {
            if (i == index)// далее условие, если index = номеру элемента массива, элемент активен, в противном же случае, пассивен
            {
                text[i].enabled = true;
            }
            else 
            {
                text[i].enabled = false;
            }
        }
    }
}
