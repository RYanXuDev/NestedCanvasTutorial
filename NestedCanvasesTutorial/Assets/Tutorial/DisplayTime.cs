using UnityEngine;
using TMPro;

namespace NestedCanvasesTutorial
{    
    public class DisplayTime : MonoBehaviour
    {
        TextMeshProUGUI timeText;

        void Awake()
        {
            timeText = GetComponent<TextMeshProUGUI>();
        }

        void Update()
        {
            timeText.text = System.DateTime.Now.ToString("T");
        }
    }
}