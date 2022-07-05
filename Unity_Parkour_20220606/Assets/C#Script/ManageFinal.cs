
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


namespace Ben {

    public class ManageFinal : MonoBehaviour
    {
        [SerializeField, Header("畫布")] private CanvasGroup groupFinal;
        [SerializeField, Header("遊戲結束標題")] private TextMeshProUGUI textFinal;

        public string stringTitle;

        private void Start()
        {
            InvokeRepeating("FadeIn", 0, 0.2f);
            textFinal.text = stringTitle;
        }

        private void FadeIn()
        {
            groupFinal.alpha += 0.1f;
            print("淡入~");

            if (groupFinal.alpha >= 1)
            {
                groupFinal.interactable = true;
                groupFinal.blocksRaycasts = true;
                CancelInvoke("FadeIn");
            }
        }
        public void Quit()
        {
            print("離開遊戲");
            Application.Quit();
        }
        public void Restart()
        {
            SceneManager.LoadScene(0);
        }
    }

    
}

