using UnityEngine; //引用unity物件


namespace MyNano
{

    /// <summary>
    /// 
    /// </summary>
    public class SystemRun : MonoBehaviour
    {
        #region 資料:保存所需的資料
        [SerializeField ,Header("跑步速度"),Tooltip("人物的移動速度"),Range(0,50)]
        private float RunSpeed = 3.5f;
        [SerializeField ,Header("跳躍高度"),Tooltip("跳躍高度"),Range(0,3000)]
        private float JumpHeight = 350;
        private Rigidbody2D rig;
        private Animator CharacterCtl;
        #endregion

        #region 功能:實作功能的方法

        private void Run()
        {
            print("正在跑步中");
            rig.velocity = new Vector2(RunSpeed, rig.velocity.y);
        }


        #endregion

        #region 事件:程式入口
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
