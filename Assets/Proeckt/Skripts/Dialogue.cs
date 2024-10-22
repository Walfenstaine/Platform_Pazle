using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public Text[] text; // ������ �� �������

    private TextMeshProUGUI textMesh;
    private int index;
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>(); // ����������� ��������� <TextMeshProUGUI>
    }
    public void Change()
    {
        if (index < text.Length) // ���������� ������, ���� �� ������ ������ �������
        {
            index += 1;
        }
        
        for (int i = 0; i < text.Length; i++) // ������ ���� for
        {
            if (i == index)// ����� �������, ���� index = ������ �������� �������, ������� �������, � ��������� �� ������, ��������
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
