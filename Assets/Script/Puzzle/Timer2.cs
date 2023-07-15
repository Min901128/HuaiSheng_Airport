using UnityEngine;
using UnityEngine.UI;

public class Timer2 : MonoBehaviour
{
    bool isStop = false;
    public Text CostTime;
    public GameObject FinishPanel;
    float timer_f = 0f;
    int timer_i = 0;
    string UseTime;

    string Puzzle2Key="Puzzle2Key";

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

            PlayerPrefs.SetInt("Puzzle2Key", timer_i);
            PlayerPrefs.Save();
        }
    }
}