using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLocation2X2 : MonoBehaviour
{
    public GameObject P1;
    public GameObject P2;
    public GameObject P3;
    public GameObject P4;
    //隨機後的位置
    
    void Start()
    {
        Vector3 P1NewPosition = P1.transform.position;
        Vector3 P2NewPosition = P2.transform.position;
        Vector3 P3NewPosition = P3.transform.position;
        Vector3 P4NewPosition = P4.transform.position;
        //Debug.Log(P1.transform.position);
        List<int> numbers = new List<int>(); // 宣告一個整數列表
        int count = 4;
        while (numbers.Count < count)
        {
            int number = Random.Range(1, count + 1); // 生成1到4之間的亂數
            if (!numbers.Contains(number)) // 如果列表中不存在該數字
            {
                numbers.Add(number); // 將該數字加入列表
            }
        }

         // 拼圖取隨機位置//PN為為PuzzleNumber
        int PN1 = numbers[0];
        int PN2 = numbers[1];
        int PN3 = numbers[2];
        int PN4 = numbers[3];

        //PN1抽到幾號位置，並定位
        switch (PN1){
            case 1:
                P1.transform.position = P1NewPosition;
                break;
            case 2:
                P1.transform.position = P2NewPosition;
                break;
            case 3:
                P1.transform.position = P3NewPosition;
                break;
            case 4:
                P1.transform.position = P4NewPosition;
                break;
        }

        //PN2抽到幾號位置，並定位
        switch (PN2){
            case 1:
                P2.transform.position = P1NewPosition;
                break;
            case 2:
                P2.transform.position = P2NewPosition;
                break;
            case 3:
                P2.transform.position = P3NewPosition;
                break;
            case 4:
                P2.transform.position = P4NewPosition;
                break;
        }

        //PN3抽到幾號位置，並定位
        switch (PN3){
            case 1:
                P3.transform.position = P1NewPosition;
                break;
            case 2:
                P3.transform.position = P2NewPosition;
                break;
            case 3:
                P3.transform.position = P3NewPosition;
                break;
            case 4:
                P3.transform.position = P4NewPosition;
                break;
        }

        //PN4抽到幾號位置，並定位
        switch (PN4){
            case 1:
                P4.transform.position = P1NewPosition;
                break;
            case 2:
                P4.transform.position = P2NewPosition;
                break;
            case 3:
                P4.transform.position = P3NewPosition;
                break;
            case 4:
                P4.transform.position = P4NewPosition;
                break;
        }
    }
}
