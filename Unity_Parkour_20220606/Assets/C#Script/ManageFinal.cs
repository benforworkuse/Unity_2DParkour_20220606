
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


namespace Ben {

    public class ManageFinal : MonoBehaviour
    {
        [SerializeField, Header("�e��")] private CanvasGroup groupFinal;
        [SerializeField, Header("�C���������D")] private TextMeshProUGUI textFinal;

        public string stringTitle;

        private void Start()
        {
            InvokeRepeating("FadeIn", 0, 0.2f);
            textFinal.text = stringTitle;
        }

        private void FadeIn()
        {
            groupFinal.alpha += 0.1f;
            print("�H�J~");

            if (groupFinal.alpha >= 1)
            {
                groupFinal.interactable = true;
                groupFinal.blocksRaycasts = true;
                CancelInvoke("FadeIn");
            }
        }
        public void Quit()
        {
            print("���}�C��");
            Application.Quit();
        }
        public void Restart()
        {
            SceneManager.LoadScene(0);
        }
    }

    
}

