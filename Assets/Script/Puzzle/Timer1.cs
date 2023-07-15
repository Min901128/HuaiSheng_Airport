using UnityEngine;
using UnityEngine.UI;

public class Timer1 : MonoBehaviour
{
    bool isStop = false;
    public Text CostTime;
    public GameObject FinishPanel;
    float timer_f = 0f;
    int timer_i = 0;
    string UseTime;

    string Puzzle1Key="Puzzle1Key";

    void Update()
    {
        if (FinishPanel.activeSelf)
        {
            isStop = true;
            CostTime.text = UseTime;
        }

        if (!isStop)
        {
            timer_f += Time.deltaTime;
            timer_i = (int)timer_f;
            UseTime = timer_i.ToString();

            PlayerPrefs.SetInt("Puzzle1Key", timer_i);
            PlayerPrefs.Save();
        }
    }
}