using UnityEngine; //�ޥ�unity����


namespace MyNano
{

    /// <summary>
    /// 
    /// </summary>
    public class SystemRun : MonoBehaviour
    {
        #region ���:�O�s�һݪ����
        [SerializeField ,Header("�]�B�t��"),Tooltip("�H�������ʳt��"),Range(0,50)]
        private float RunSpeed = 3.5f;
        [SerializeField ,Header("���D����"),Tooltip("���D����"),Range(0,3000)]
        private float JumpHeight = 350;
        private Rigidbody2D rig;
        private Animator CharacterCtl;
        #endregion

        #region �\��:��@�\�઺��k


        #endregion

        #region �ƥ�:�{���J�f
        private void Start()
        {
            print("Hello world.");
        }
        #endregion
    }

}
