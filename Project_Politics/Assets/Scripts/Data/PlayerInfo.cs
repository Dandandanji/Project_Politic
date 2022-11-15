using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfo : MonoBehaviour
{

    // ���� ī������ ���� ������ ���� ������ �Ǹ�
    [SerializeField] public static int[] stat = new int[7];

    [SerializeField] public Canvas canvas;
    [SerializeField] public GameObject[] Scores = new GameObject[5];
    [SerializeField] public Button[] buttons = new Button[5];

    void Start()
    {
        Transform go = transform.GetChild(0);

        for (int i = 0; i < 5; i++)
        {
            stat[i] = 100;
            Scores[i].GetComponent<Text>().text = stat[i].ToString();
            buttons[i].GetComponent<StatUpButton>().Init(i, this);
        }
    }

    public void updateScore(int num)
    {
        stat[num]++;
        Scores[num].GetComponent<Text>().text = stat[num].ToString();
    }
}
