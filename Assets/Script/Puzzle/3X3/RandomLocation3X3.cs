using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLocation3X3 : MonoBehaviour
{
    public GameObject P1;
    public GameObject P2;
    public GameObject P3;
    public GameObject P4;
    public GameObject P5;
    public GameObject P6;
    public GameObject P7;
    public GameObject P8;
    public GameObject P9;
    
    
    void Start()
    {   
        //隨機後的位置
        Vector3 P1NewPosition = P1.transform.position;
        Vector3 P2NewPosition = P2.transform.position;
        Vector3 P3NewPosition = P3.transform.position;
        Vector3 P4NewPosition = P4.transform.position;
        Vector3 P5NewPosition = P5.transform.position;
        Vector3 P6NewPosition = P6.transform.position;
        Vector3 P7NewPosition = P7.transform.position;
        Vector3 P8NewPosition = P8.transform.position;
        Vector3 P9NewPosition = P9.transform.position;
        //Debug.Log(P1.transform.position);
        List<int> numbers = new List<int>(); // 宣告一個整數列表
        int count = 9;
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
        int PN5 = numbers[4];
        int PN6 = numbers[5];
        int PN7 = numbers[6];
        int PN8 = numbers[7];
        int PN9 = numbers[8];

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
            case 5:
                P1.transform.position = P5NewPosition;
                break;
            case 6:
                P1.transform.position = P6NewPosition;
                break;
            case 7:
                P1.transform.position = P7NewPosition;
                break;
            case 8:
                P1.transform.position = P8NewPosition;
                break;
            case 9:
                P1.transform.position = P9NewPosition;
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
            case 5:
                P2.transform.position = P5NewPosition;
                break;
            case 6:
                P2.transform.position = P6NewPosition;
                break;
            case 7:
                P2.transform.position = P7NewPosition;
                break;
            case 8:
                P2.transform.position = P8NewPosition;
                break;
            case 9:
                P2.transform.position = P9NewPosition;
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
            case 5:
                P3.transform.position = P5NewPosition;
                break;
            case 6:
                P3.transform.position = P6NewPosition;
                break;
            case 7:
                P3.transform.position = P7NewPosition;
                break;
            case 8:
                P3.transform.position = P8NewPosition;
                break;
            case 9:
                P3.transform.position = P9NewPosition;
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
            case 5:
                P4.transform.position = P5NewPosition;
                break;
            case 6:
                P4.transform.position = P6NewPosition;
                break;
            case 7:
                P4.transform.position = P7NewPosition;
                break;
            case 8:
                P4.transform.position = P8NewPosition;
                break;
            case 9:
                P4.transform.position = P9NewPosition;
                break;
        }
        //PN5抽到幾號位置，並定位
        switch (PN5){
            case 1:
                P5.transform.position = P1NewPosition;
                break;
            case 2:
                P5.transform.position = P2NewPosition;
                break;
            case 3:
                P5.transform.position = P3NewPosition;
                break;
            case 4:
                P5.transform.position = P4NewPosition;
                break;
            case 5:
                P5.transform.position = P5NewPosition;
                break;
            case 6:
                P5.transform.position = P6NewPosition;
                break;
            case 7:
                P5.transform.position = P7NewPosition;
                break;
            case 8:
                P5.transform.position = P8NewPosition;
                break;
            case 9:
                P5.transform.position = P9NewPosition;
                break;
        }

        //PN6抽到幾號位置，並定位
        switch (PN6){
            case 1:
                P6.transform.position = P1NewPosition;
                break;
            case 2:
                P6.transform.position = P2NewPosition;
                break;
            case 3:
                P6.transform.position = P3NewPosition;
                break;
            case 4:
                P6.transform.position = P4NewPosition;
                break;
            case 5:
                P6.transform.position = P5NewPosition;
                break;
            case 6:
                P6.transform.position = P6NewPosition;
                break;
            case 7:
                P6.transform.position = P7NewPosition;
                break;
            case 8:
                P6.transform.position = P8NewPosition;
                break;
            case 9:
                P6.transform.position = P9NewPosition;
                break;
        }

        //PN7抽到幾號位置，並定位
        switch (PN7){
            case 1:
                P7.transform.position = P1NewPosition;
                break;
            case 2:
                P7.transform.position = P2NewPosition;
                break;
            case 3:
                P7.transform.position = P3NewPosition;
                break;
            case 4:
                P7.transform.position = P4NewPosition;
                break;
            case 5:
                P7.transform.position = P5NewPosition;
                break;
            case 6:
                P7.transform.position = P6NewPosition;
                break;
            case 7:
                P7.transform.position = P7NewPosition;
                break;
            case 8:
                P7.transform.position = P8NewPosition;
                break;
            case 9:
                P7.transform.position = P9NewPosition;
                break;
        }

        //PN8抽到幾號位置，並定位
        switch (PN8){
            case 1:
                P8.transform.position = P1NewPosition;
                break;
            case 2:
                P8.transform.position = P2NewPosition;
                break;
            case 3:
                P8.transform.position = P3NewPosition;
                break;
            case 4:
                P8.transform.position = P4NewPosition;
                break;
            case 5:
                P8.transform.position = P5NewPosition;
                break;
            case 6:
                P8.transform.position = P6NewPosition;
                break;
            case 7:
                P8.transform.position = P7NewPosition;
                break;
            case 8:
                P8.transform.position = P8NewPosition;
                break;
            case 9:
                P8.transform.position = P9NewPosition;
                break;
        }

        //PN9抽到幾號位置，並定位
        switch (PN9){
            case 1:
                P9.transform.position = P1NewPosition;
                break;
            case 2:
                P9.transform.position = P2NewPosition;
                break;
            case 3:
                P9.transform.position = P3NewPosition;
                break;
            case 4:
                P9.transform.position = P4NewPosition;
                break;
            case 5:
                P9.transform.position = P5NewPosition;
                break;
            case 6:
                P9.transform.position = P6NewPosition;
                break;
            case 7:
                P9.transform.position = P7NewPosition;
                break;
            case 8:
                P9.transform.position = P8NewPosition;
                break;
            case 9:
                P9.transform.position = P9NewPosition;
                break;
        }
    }
}