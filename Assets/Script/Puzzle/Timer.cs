using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    bool isStop = false;
    public Text CostTime;
    public GameObject FinishPanel;
    float timer_f = 0f;
    int timer_i = 0;
    string UseTime;

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
        }
    }
}