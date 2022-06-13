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


        #endregion

        #region 事件:程式入口
        private void Start()
        {
            print("Hello world.");
        }
        #endregion
    }

}
