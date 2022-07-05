
using UnityEngine;


namespace Ben {
    public class ManageDeath : MonoBehaviour
    {
        [SerializeField, Header("�ؼЦW��")]
        private string nameTarget = "�Ԫ��t";
        [SerializeField,Header("�������")]
        private ManageFinal manageFinal;
        [SerializeField, Header("��v������")]
        private GameObject objCM;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.name.Contains(nameTarget))
            {
                manageFinal.enabled = true;
                manageFinal.stringTitle = "�D�ԥ���!";
                objCM.SetActive(false);
            }
        }

    }
}

