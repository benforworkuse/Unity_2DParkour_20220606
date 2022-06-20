using UnityEngine;

namespace Ben
{
    /// <summary>
    /// ���骫��:�s�b������W������
    /// </summary>
    public class APINONStatic : MonoBehaviour
    {
        [SerializeField]
        GameObject frog;
        [SerializeField]
        private Transform endPoint;


        void Start()
        {
            print("�Ԫ̵쪺�Ұʪ��A: "+frog.activeInHierarchy);
            frog.layer = 4;
            frog.tag = "player";
            print("�Ԫ̵쪺tag: " + frog.tag);
            print("�Ԫ̵쪺layer: " + frog.layer);
            frog.SetActive(false);

            print("���I���y��: "+endPoint.position);
            endPoint.position = new Vector3(0, 0, 0);
        }
        private void Update()
        {
            endPoint.Translate(1.5f,0,0);
            endPoint.Rotate(0, 0, 3.5f);
        }
    }

}