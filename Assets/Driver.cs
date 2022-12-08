using TMPro;
using UnityEngine;

namespace DefaultNamespace
{
    public class Driver : MonoBehaviour
    {
        [SerializeField] private CountDown countDown;
        [SerializeField] private TMP_Text  countDownUI;
        [SerializeField] private 
        

        public void SetTargetTime(long finalTimeStamp)
        {   
            countDown.SetTargetTime();
        }

        private void Update()
        {
            countDownUI.text = countDown.GetCurrentTimeString;
        }
    }
}