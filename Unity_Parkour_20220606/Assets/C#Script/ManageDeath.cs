
using UnityEngine;


namespace Ben {
    public class ManageDeath : MonoBehaviour
    {
        [SerializeField, Header("目標名稱")]
        private string nameTarget = "忍者龜";
        [SerializeField,Header("結束控制器")]
        private ManageFinal manageFinal;
        [SerializeField, Header("攝影機物件")]
        private GameObject objCM;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.name.Contains(nameTarget))
            {
                manageFinal.enabled = true;
                manageFinal.stringTitle = "挑戰失敗!";
                objCM.SetActive(false);
            }
        }

    }
}

