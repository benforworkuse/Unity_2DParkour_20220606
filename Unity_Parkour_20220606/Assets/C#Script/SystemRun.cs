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

        private void Run()
        {
            print("���b�]�B��");
            rig.velocity = new Vector2(RunSpeed, rig.velocity.y);
        }


        #endregion

        #region �ƥ�:�{���J�f
        private void Awake()
        {
            rig = GetComponent<Rigidbody2D>();
            CharacterCtl = GetComponent<Animator>();
        }

        private void Start()
        {
            print("Hello world.");
            Physics2D.gravity=new Vector2(0,-1f);
            Time.timeScale = 0.5f;
            
        }

        private void Update()
        {
            //print("<color=yellow>Update now.</color>");
            //print(Random.Range(10f, 100f));
            //print(Random.Range(1, 100));
            Run();
        }
        #endregion
    }

}
